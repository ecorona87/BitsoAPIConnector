using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsoConnectorLibrary
{
    public class Balance
    {
        public string currency { get; set; }
        public string total { get; set; }
        public string locked { get; set; }
        public string available { get; set; }
    }

    public class AccountBalancePayload
    {
        public List<Balance> balances { get; set; }
    }

    public class AccountBalanceRootObject
    {
        public bool success { get; set; }
        public AccountBalancePayload payload { get; set; }
    }
}
