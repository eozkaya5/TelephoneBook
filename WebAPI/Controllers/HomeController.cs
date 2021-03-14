using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using LogLevel = NLog.LogLevel;

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

        [Route("/Error")]
        public IActionResult Error()
        {
            var error = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            var logger = LogManager.GetLogger("FileManager");
            logger.Log(LogLevel.Error, $"\nHatanın gerçekleştiği yer:{error.Path} \nHata: {error.Error.Message}\nStackTrace:{ error.Error.StackTrace}");
            return View();
        }
    }
}
