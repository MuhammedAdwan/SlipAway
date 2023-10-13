using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SlipAway.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SlipAway.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //to pass the data from the controller to the index page
        public IActionResult Index()
        {
            return View();
        }
        //to pass the data from the controller to the privacy page
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //to pass the data from the controller to the AboutUs page
        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
