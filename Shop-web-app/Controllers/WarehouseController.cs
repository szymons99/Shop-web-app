using Microsoft.AspNetCore.Mvc;
using Shop_web_app.Models;

namespace Shop_web_app.Controllers
{
    public class WarehouseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product body)
        {
            if(!ModelState.IsValid)
            {
                return View(body);
            }

            return RedirectToAction("Add");
        }
    }
}
