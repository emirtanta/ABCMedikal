using ABCMedical.Models.Context;
using ABCMedical.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ABCMedical.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        // Register
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Customer model)
        {
            if (ModelState.IsValid)
            {
                _context.Customers.Add(model);

                _context.SaveChanges();

                return RedirectToAction("Login");
            }
            return View(model);
        }

        // Login
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var customer = _context.Customers
                .FirstOrDefault(c => c.Username == username && c.Password == password);

            if (customer != null)
            {
                HttpContext.Session.SetInt32("CustomerID", customer.CustomerID);

                // Kullanıcının ad ve soyad bilgilerini oturumda sakla
                HttpContext.Session.SetString("CustomerName", customer.CustomerName);
                HttpContext.Session.SetString("CustomerSurname", customer.CustomerSurname);

                return RedirectToAction("Index","Home");
            }

            ViewBag.Error = "Hatalı kullanıcı adı veya şifre.";
            return View();
        }

        // Profile
        public IActionResult Profile()
        {
            int? customerId = HttpContext.Session.GetInt32("CustomerID");

            if (customerId == null)
            {
                return RedirectToAction("Login");
            }

            var customer = _context.Customers.Find(customerId);
            return View(customer);
        }

        // Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index","Home");
        }
    }
}
