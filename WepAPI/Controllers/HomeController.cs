
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogLevel = NLog.LogLevel;

namespace WebAPI.Controllers
{

    public class HomeController : Controller
    {
        public ILogger<HomeController> _logger;
        private IMemoryCache memoryCache;
        public HomeController(ILogger<HomeController> logger, IMemoryCache cache)
        {
            _logger = logger;
            this.memoryCache = cache;

        }

        [Route("/Index")]
        public IActionResult Index()
        {
            ViewBag.UserName = User.Identity.Name;
            DateTime time;

            bool cacheEntryOptios = memoryCache.TryGetValue("Time", out time);
            if (!cacheEntryOptios)
            {
                time = DateTime.Now;
                var cache = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromSeconds(30));
                object p = memoryCache.Set("Time", time, cache);
            }

            return View(time);
        }
        [Route("/Error")]
        public IActionResult Error()
        {
            var error = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            var logger = LogManager.GetLogger("FileManager");
            logger.Log(LogLevel.Error, $"\nHatan�n ger�ekle�ti�i yer:{error.Path} \nHata: {error.Error.Message}\nStackTrace:{ error.Error.StackTrace}");
            return View();
        }



    }
}
