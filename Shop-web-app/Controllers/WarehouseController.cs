﻿using Microsoft.AspNetCore.Mvc;
using Shop_web_app.Models;
using Shop_web_app.Services;
using Shop_web_app.Services.Interfaces;

namespace Shop_web_app.Controllers
{
    public class WarehouseController : Controller
    {
        private readonly IWarehouseService _warehouseService;

        public WarehouseController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

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

            var id = _warehouseService.Save(body);

            TempData["ProductId"] = id;

            return RedirectToAction("Add");
        }
    }
}
