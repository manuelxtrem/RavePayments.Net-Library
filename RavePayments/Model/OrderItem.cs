using System;
using System.Collections.Generic;
using System.Text;

namespace RavePayments.Model
{
    public class OrderItem
{
    
        public string ItemCode { get; set; }

        public string ItemName { get; set; }

        public double UnitPrice { get; set; }

        public int Quantity { get; set; }

        public double SubTotal { get; set; }

    }
}
