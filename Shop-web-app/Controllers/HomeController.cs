using Microsoft.AspNetCore.Mvc;
using Shop_web_app.Models;
using System.Diagnostics;

namespace Shop_web_app.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Redirect()
        {
            return RedirectToAction("Privacy");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("test-route/{name}")]
        public IActionResult Product(string name)
        {
            return View();
        }
    }
}