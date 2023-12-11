using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using test.Models;

namespace test.Controllers
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

        public IActionResult Search_Results()
        {
            return View();
        }

        public IActionResult CreateRoute()
        {
            return View();
        }

        public IActionResult MyPage()
        {
            return View();
        }

        public IActionResult route_detail()
        {
            return View();
        }
        public IActionResult route()
        {
            return View();
        }
        public IActionResult acsess()
        {
            return View();
        }
        public IActionResult check()
        {
            return View();
        }

        public IActionResult notice()
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