using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace isMART.API.Models
{
    public class Seller
    {
        public string SellerName { get; set; }
        public int SellerID { get; set; }
        public string SellerType { get; set; }// Manufacturer/Retailer
        public string TaxID { get; set; }
        public string Adderss { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
    }
}