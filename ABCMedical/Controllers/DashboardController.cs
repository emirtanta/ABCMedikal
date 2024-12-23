using Microsoft.AspNetCore.Mvc;

namespace ABCMedical.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
