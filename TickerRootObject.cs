using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsoConnectorLibrary
{
    public class Ticker
    {
        public string book { get; set; }
        public string volume { get; set; }
        public string high { get; set; }
        public string last { get; set; }
        public string low { get; set; }
        public string vwap { get; set; }
        public string ask { get; set; }
        public string bid { get; set; }
        public DateTime created_at { get; set; }
    }

    public class TickerRootObject
    {
        public bool success { get; set; }
        public Ticker payload { get; set; }
    }
}
