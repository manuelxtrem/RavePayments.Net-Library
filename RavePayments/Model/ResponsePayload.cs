using System;
using System.Collections.Generic;
using System.Text;

namespace RavePayments.Model
{
    public class ResponsePayload<T>
    {
        public string status { get; set; }

        public string message { get; set; }

        public T data { get; set; }

    }
    
}
