using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace isMART.API.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
    }
}