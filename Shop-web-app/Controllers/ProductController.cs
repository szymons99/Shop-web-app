using Microsoft.AspNetCore.Mvc;
using Shop_web_app.Models;
using Shop_web_app.Services.Interfaces;

namespace Shop_web_app.Controllers
{
    public class ProductController : Controller
    {
        private readonly IWarehouseService _warehouseService;

        public ProductController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

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
            var productList = _warehouseService.GetAll();

            return View(productList);
        }
    }
}
