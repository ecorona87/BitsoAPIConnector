using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using bscheiman.Common.Util;
using RestSharp;

namespace BitsoConnectorLibrary
{
    
    public class BitsoAPIConnector
    {
        private RestClient client;
        public string _key { get; set; }
        public string _secret { get; set; }
        public long _nonce { get; set; }
        public string _signature { get; set; }
        public BitsoAPIConnector(string key, string secret)
        {
            client = new RestClient("https://api.bitso.com/v3/");
            _key = key;
            _secret = secret;
        }

        public Order PlaceOrder(CurrencyPair book, OrderSide side, OrderType type, decimal major, decimal price)
        {
            OrderBody orderBody = new OrderBody();
            orderBody.book = book.ToString();
            orderBody.side = side.ToString();
            orderBody.type = type.ToString();
            orderBody.major = major.ToString();
            orderBody.price = price.ToString();

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

            IRestResponse<T> response = client.Execute<T>(request);
            return response.Data;
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
