using System;
using System.Collections.Generic;
using System.Text;

namespace RavePayments.Model
{
    public class RaveOptions
    {
        public bool TestMode { get; set; }

        public string SecretKey { get; set; }

        public string PublicKey { get; set; }

    }
}
