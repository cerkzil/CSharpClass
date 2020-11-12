using Microsoft.AspNetCore.Mvc;
using Skaitykla.Domains;
using Skaitykla.MVC.Models;
using System.Threading;

namespace Skaitykla.MVC.Controllers
{
    public class AuthController : Controller
    {
        private User _adminUser;

        public AuthController()
        {
            _adminUser = new User() { Email = "milk@milk.com", Password = "pass", IsAdmin = true, Id = 1 };
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.AuthError = "blogi prisijungimo duomenys";
                return View("~/Views/Auth/Index.cshtml");
            }

            //check if it is admin
            if (model.Email == _adminUser.Email && model.Password == _adminUser.Password)
            {
                return RedirectToAction("Index", "Admin");
            }


            return View();
        }
    }
}
