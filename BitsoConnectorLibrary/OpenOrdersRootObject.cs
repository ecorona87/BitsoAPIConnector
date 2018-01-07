using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsoConnectorLibrary
{
    public class OpenOrder
    {
        public string book { get; set; }
        public string original_amount { get; set; }
        public string unfilled_amount { get; set; }
        public string original_value { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string price { get; set; }
        public string oid { get; set; }
        public string side { get; set; }
        public string status { get; set; }
        public string type { get; set; }
    }

    public class OpenOrdersRootObject
    {
        public bool success { get; set; }
        public List<OpenOrder> payload { get; set; }
    }
}
