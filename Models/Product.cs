using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace isMART.API.Models
{
    public class Product
    {
        public string Name { get ; set ; }
        public int ProductID { get; set; }
        public string ProductCode { get; set; }
        public int TotalQuantity { get; set; }
        public int AvailableQuantity { get; set; }
        public string ProductCategory{ get; set; }
        public decimal Price { get; set; }
        public int SellerID { get; set; }
    }
}