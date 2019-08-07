using System;
using System.Collections.Generic;
using System.Text;

namespace RavePayments.Model
{
    public class RequestPayload
    {
        public string PBFPubKey { get; set; }

        public string client { get; set; }

        public string alg = "3DES-24";

    }
}