using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
   
        public IActionResult Information()
        {
            _logger.LogInformation("Information mesajı...");
            return View();
        }
        public IActionResult Error()
        {
            _logger.LogError("Error mesajı...");
            return View();
        }
        public IActionResult Warning()
        {
            _logger.LogWarning("Warning mesajı...");
            return View();
        }
        public IActionResult Index()
        {
            ViewBag.UserName = User.Identity.Name;

            return View();
        }

       
    }
}
