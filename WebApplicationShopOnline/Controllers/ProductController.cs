using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product("пирожок", "с ливером", 50);
            //ViewBag.Product = product;
            return View(product);
        }

        //public string Index()
        //{
        //    Product product = new Product("пирожок", "с ливером", 50);
        //    return product.ToString(); 
        //}
    }
}
