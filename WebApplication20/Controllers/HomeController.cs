using javax.jws;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication20.Models;

namespace WebApplication20.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Double()
        {
            return View();
        }
        public IActionResult Triple()
        {
            return View();
        }
        public IActionResult Single()
        {
            return View();
        }
        public IActionResult Feedback()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
