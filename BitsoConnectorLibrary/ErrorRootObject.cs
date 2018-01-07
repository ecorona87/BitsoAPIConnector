using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsoConnectorLibrary
{
    public class Error
    {
        public int code { get; set; }
        public string message { get; set; }
    }

    public class ErrorRootObject
    {
        public bool success { get; set; }
        public Error error { get; set; }
    }
}
