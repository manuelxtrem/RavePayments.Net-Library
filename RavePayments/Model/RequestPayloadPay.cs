using System;
using System.Collections.Generic;
using System.Text;

namespace RavePayments.Model
{
    public class RequestPayloadPay
    {
        public string PBFPubKey { get; set; }

        public string currency { get; set; } // GHS

        public string country { get; set; } // GH

        public double amount { get; set; }

        public string email { get; set; }

        public string phonenumber { get; set; }

        public string firstname { get; set; }

        public string lastname { get; set; }

        public string IP { get; set; }

        public string txRef { get; set; }

        public string meta { get; set; }

        // public string redirect_url { get; set; }

        public string device_fingerprint { get; set; }
    }
}