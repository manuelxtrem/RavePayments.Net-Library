using System;
using System.Collections.Generic;
using System.Text;

namespace RavePayments.Model
{
    public class ResponsePayloadValidate
    {
        public ValidateData data { get; set; }

        public ResponsePayloadPayCard tx { get; set; }
    }

    public class ValidateData
    {
        public string responsecode { get; set; }

        public string responsemessage { get; set; }
    }

}
