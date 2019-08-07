using System;
using System.Collections.Generic;
using System.Text;

namespace RavePayments.Model
{
    public class RequestPayloadPayCard : RequestPayloadPay
    {
        public string cardno { get; set; }
        public string cvv { get; set; }
        public string expirymonth { get; set; }
        public string expiryyear { get; set; }
        public string pin { get; set; }
        public string suggested_auth { get; set; }
    }
}