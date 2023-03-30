using Microsoft.AspNetCore.Mvc;
using Shop_web_app.Models;

namespace Shop_web_app.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {
            var product = new Product
            {
                Id = 1,
                Category = "Car",
                Description = "Nice Car",
                Name = "Lexus CT250h",
                Price = 200000M
            };

            return View(product);
        }

        public IActionResult List()
        {
            var productList = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Category = "Car",
                    Description = "Nice Car",
                    Name = "Lexus CT250h",
                    Price = 200000M
                },
                new Product
                {
                    Id = 2,
                    Category = "Car",
                    Description = "Nice Car",
                    Name = "Lexus CT250h",
                    Price = 200000M
                },
                new Product
                {
                    Id = 3,
                    Category = "Car",
                    Description = "Nice Car",
                    Name = "Lexus CT250h",
                    Price = 200000M
                }
            };

            return View(productList);
        }
    }
}
