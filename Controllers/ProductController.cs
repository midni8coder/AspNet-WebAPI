using isMART.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace isMART.API.Controllers
{
    public class ProductController : ApiController
    {
        // GET api/<controller>
        public static List<Product> products = new List<Product>();
        public void SetProductDetails()
        {
            products.Add(new Product()
            {
                Name = "AXE Refresh Deo",
                AvailableQuantity = 10,
                Price = 190,
                ProductCategory = "Deo&Perfumes",
                ProductCode = "AXERDM12",
                ProductID = 1,
                SellerID = 1,
                TotalQuantity = 15
            });

            products.Add(new Product()
            {
                Name = "Killer Jeans",
                AvailableQuantity = 25,
                Price = 3499,
                ProductCategory = "MensWear",
                ProductCode = "KillerXJ900",
                ProductID = 2,
                SellerID = 1,
                TotalQuantity = 53
            });

            products.Add(new Product()
            {
                Name = "Rebook Shoes",
                AvailableQuantity = 23,
                Price = 3250,
                ProductCategory = "Shoes",
                ProductCode = "RBKM093",
                ProductID = 3,
                SellerID = 1,
                TotalQuantity = 42
            });
        }

        public IEnumerable<Product> GetAllProducts()
        {
            if (products.Count == 0)
                SetProductDetails();
            return products;
        }

        // GET api/<controller>/5
        public Product GetProductDetail(int productID)
        {
            if (products.Count == 0)
                SetProductDetails();
            return products.Where(x => x.ProductID == productID).FirstOrDefault();
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}