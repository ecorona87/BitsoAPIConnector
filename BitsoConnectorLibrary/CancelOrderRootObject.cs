using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsoConnectorLibrary
{
    public class CancelOrder
    {
        public string oid { get; set; }
    }

    public class CancelOrderRootObject
    {
        public bool success { get; set; }
        public CancelOrder payload { get; set; }
    }
}
