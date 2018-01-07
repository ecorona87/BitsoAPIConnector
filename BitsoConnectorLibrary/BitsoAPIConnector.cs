using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using bscheiman.Common.Util;
using RestSharp;
using Newtonsoft.Json.Converters;
namespace BitsoConnectorLibrary
{
    
    public class BitsoAPIConnector
    {
        private RestClient client;
        public string _key { get; set; }
        public string _secret { get; set; }
        public long _nonce { get; set; }
        public string _signature { get; set; }
        public CurrencyPair _currency { get; set; }

        private DateTime _TimerStart;

        public int CallsCounter { get; set; }
        public BitsoAPIConnector(string key, string secret, CurrencyPair currency)
        {
            client = new RestClient("https://api.bitso.com/v3/");
            _key = key;
            _secret = secret;
            _currency = currency;
            CallsCounter = 0;
        }

        public BitsoAPIConnector(string key, string secret)
        {
            client = new RestClient("https://api.bitso.com/v3/");
            _key = key;
            _secret = secret;
            CallsCounter = 0;
        }

        private OrderBody CreateOrderBody(OrderSide side,string major, string minor, string price)
        {
            OrderBody orderBody = new OrderBody();
            orderBody.book = _currency.ToString();
            orderBody.side = side.ToString();
            orderBody.type = OrderType.limit.ToString();
            orderBody.major = major;
            orderBody.minor = minor;
            orderBody.price = price;
            return orderBody;
        }

        public Order PlaceSellOrder(string major, string minor, string price)
        {
            OrderBody orderBody = CreateOrderBody(OrderSide.sell, major, minor, price);
            return ExecuteRequest<OrdersRootObject>("orders/", "", RestSharp.Method.POST, true, orderBody).payload;
        }

        public Order PlaceBuyOrder(string major, string minor, string price)
        {
            OrderBody orderBody = CreateOrderBody(OrderSide.buy, major, minor, price);
            return ExecuteRequest<OrdersRootObject>("orders/", "", RestSharp.Method.POST, true, orderBody).payload;
        }

        public Ticker GetTickerInfo(CurrencyPair book)
        {
            return ExecuteRequest<TickerRootObject>("ticker/", "?book=" + book.ToString(), Method.GET, false).payload;
        }

        public CancelOrder CancelOrderByID(string orderID)
        {
            return ExecuteRequest<CancelOrder>("orders/", orderID + "/", RestSharp.Method.DELETE, true);
        }

        public List<OpenOrder> GetOpenOrders(CurrencyPair book)
        {
            return ExecuteRequest<OpenOrdersRootObject>("open_orders/", "?book=" + book.ToString(), Method.GET, true).payload;
        }

        public List<Fee> GetFees()
        {
            return ExecuteRequest<FeesRootObject>("fees/", "", Method.GET, true).payload.fees;
        }

        public List<AvailableBooks> GetAvailableBooks()
        {
            return ExecuteRequest<AvailableBooksRootObject>("available_books/", "", Method.GET, false).payload;
        }

        public List<Balance> GetAccountBalances()
        {
            return ExecuteRequest<AccountBalanceRootObject>("balance/", "", Method.GET, true).payload.balances;
        }

        private T ExecuteRequest<T>(string resource,string queryString ,RestSharp.Method httpMethod,bool requiresAuthorization , object requestBody = null) where T : new()
        {
            
            RestRequest request = new RestRequest(resource + queryString, httpMethod);
            request.RequestFormat = DataFormat.Json;

            string jsonPayload = "";  

            if (requestBody != null)
            {
                jsonPayload = request.JsonSerializer.Serialize(requestBody);
                request.AddParameter("application/json; charset=utf-8", jsonPayload, ParameterType.RequestBody);
            }
                
            
            if (requiresAuthorization)
                request.AddHeader("Authorization", CreateAuthenticationHeader(httpMethod.ToString(), resource + queryString, jsonPayload));

            if (_TimerStart == null)
                _TimerStart = DateTime.Now;

            if((DateTime.Now - _TimerStart).TotalSeconds >= 300)
            {
                _TimerStart = DateTime.Now;
                CallsCounter = 0;
            }

            IRestResponse<T> response;

            if (CallsCounter < 299)
            {
                response = client.Execute<T>(request);
                CallsCounter++;
            }
            else
            {
                throw new ApplicationException("Solo 300 llamadas son permitidas cada 5 minutos, por favor espere");
            }

            if(response.IsSuccessful)
            {
                return response.Data;
            }
            else
            {

                ErrorRootObject errorInfo = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorRootObject>(response.Content.ToString());
                throw new ApplicationException(string.Format("{0}, Codigo : {1}", errorInfo.error.message, errorInfo.error.code));
            }
            
        }

        private string CreateAuthenticationHeader(string httpVerb, string requestPath, string jsonPayload = "")
        {
            var encoding = new System.Text.ASCIIEncoding();

            byte[] keyByte = encoding.GetBytes(_secret);

            _nonce = DateUtil.NowMilli;

            byte[] messageBytes = encoding.GetBytes(_nonce + httpVerb + "/v3/" + requestPath + jsonPayload);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                var hash = new HMACSHA256(keyByte);
                byte[] signature1 = hash.ComputeHash(messageBytes);
                _signature = BitConverter.ToString(signature1).Replace("-", "").ToLower();
            }

            return String.Format("Bitso {0}:{1}:{2}", _key, _nonce, _signature);
        }
         
    }

    public enum CurrencyPair
    {
        btc_mxn, eth_mxn, xrp_mxn
    }
    public enum OrderSide
    {
        buy, sell
    }

    public enum OrderType
    {
        market, limit
    }
}
