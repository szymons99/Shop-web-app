using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop_web_app.Services.Interfaces;

namespace Shop_web_app.Controllers
{
    [Authorize]
    public class ApiController : Controller
    {
        private readonly IApiService _apiService;

        public ApiController(IApiService apiService)
        {
            _apiService = apiService;
        }

        public IActionResult Index()
        {
            var response =_apiService.Get("london");
            return View(response);
        }
    }
}
