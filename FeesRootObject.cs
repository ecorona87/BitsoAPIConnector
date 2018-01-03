using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsoConnectorLibrary
{
    public class Fee
    {
        public string book { get; set; }
        public string fee_decimal { get; set; }
        public string fee_percent { get; set; }
    }

    public class WithdrawalFees
    {
        public string btc { get; set; }
        public string eth { get; set; }
    }

    public class FeesPayload
    {
        public List<Fee> fees { get; set; }
        public WithdrawalFees withdrawal_fees { get; set; }
    }

    public class FeesRootObject
    {
        public bool success { get; set; }
        public FeesPayload payload { get; set; }
    }
}
