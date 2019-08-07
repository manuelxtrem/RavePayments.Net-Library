using System;
using System.Collections.Generic;
using System.Text;

namespace RavePayments.Model
{
    public class RequestPayloadPayMomoGH : RequestPayloadPay
    {
        public string payment_type = "mobilemoneygh";

        public string network { get; set; }
        
        // vodafone only
        public string voucher { get; set; }

        public int is_mobile_money_gh { get; set; }

    }
}