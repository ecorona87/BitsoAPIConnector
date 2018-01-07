using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsoConnectorLibrary
{
    public class Order
    {
        public string oid { get; set; }
    }

    public class OrdersRootObject
    {
        public bool success { get; set; }
        public Order payload { get; set; }
    }

    public class OrderBody
    {
        public string book { get; set; }
        public string side { get; set; }
        public string type { get; set; }
        public string major { get; set; }
        public string minor { get; set; }
        public string price { get; set; }
    }
}
