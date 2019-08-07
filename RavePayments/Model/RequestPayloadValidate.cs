using System;
using System.Collections.Generic;
using System.Text;

namespace RavePayments.Model
{
    public class RequestPayloadValidate
    {
        public string PBFPubKey { get; set; }

        public string transaction_reference { get; set; }

        public string otp { get; set; }

    }
}