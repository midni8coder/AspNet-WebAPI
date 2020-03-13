using isMART.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace isMART.API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public async Task<ActionResult> GetProductsFromAPI(int productID=0)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44355/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            Product product = null;
            List<Product> products = new List<Product>();
            if (productID > 0)
            {
                HttpResponseMessage response = await client.GetAsync("api/Product/GetProductDetail?productID=1");
                if (response.IsSuccessStatusCode)
                {
                    product = await response.Content.ReadAsAsync<Product>();
                    products.Add(product);
                }

                //return Json(product, JsonRequestBehavior
                //    .AllowGet);
            }
            else
            {
                HttpResponseMessage response = await client.GetAsync("api/Product/GetAllProducts");
                if (response.IsSuccessStatusCode)
                {
                    products = await response.Content.ReadAsAsync<List<Product>>();
                }
                //return Json(product, JsonRequestBehavior
                //    .AllowGet);
            }
            return View(products);
        }
    }
}
