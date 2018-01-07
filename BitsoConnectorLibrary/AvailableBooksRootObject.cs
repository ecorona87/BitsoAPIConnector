using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsoConnectorLibrary
{
    public class AvailableBooks
    {
        public string book { get; set; }
        public string minimum_amount { get; set; }
        public string maximum_amount { get; set; }
        public string minimum_price { get; set; }
        public string maximum_price { get; set; }
        public string minimum_value { get; set; }
        public string maximum_value { get; set; }
    }

    public class AvailableBooksRootObject
    {
        public bool success { get; set; }
        public List<AvailableBooks> payload { get; set; }
    }
}
