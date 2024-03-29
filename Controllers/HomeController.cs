﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SoftwareFabLabUSMP.Models;

namespace SoftwareFabLabUSMP.Controllers
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
        public IActionResult Pasante()
        {
            return View();
        }
        public IActionResult Inventario()
        {
            return View();
        }
        public IActionResult RegistroInventario()
        {
            return View();
        }

        // [HttpPost]
        // public IActionResult Pasante(string nombre)
        // {
        //     if(ModelState.IsValid){
        //         return RedirectToAction("Index");
        //     }
        // }

        // public IActionResult Privacy()
        // {
        //     return View();
        // }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
