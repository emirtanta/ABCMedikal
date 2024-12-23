using ABCMedical.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ABCMedical.Controllers
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
            //ViewData["CustomerID"] = HttpContext.Session.GetString("CustomerID");
            
            return View();
        }

        public IActionResult Sepetim()
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
