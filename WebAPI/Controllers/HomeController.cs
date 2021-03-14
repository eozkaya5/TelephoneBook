
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
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
      


    }
}
