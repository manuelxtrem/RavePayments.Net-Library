using System;
using System.Collections.Generic;
using System.Text;

namespace RavePayments.Model
{
    public class PaymentOptions
    {
        public string Name { get; set; }

        public string ShortName { get; set; }

        public double MaximumAmount { get; set; }

        public bool Active { get; set; }

        public string Reason { get; set; }

        public string Logourl { get; set; }
    }
}
