using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace isMART.API.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Product> OrderItems { get; set; }
        public decimal OrderAmount { get; set; }
        public string CouponCode { get; set; }
        public string DeliveryAddress { get; set; }
        public int CustomerID { get; set; }

    }
}