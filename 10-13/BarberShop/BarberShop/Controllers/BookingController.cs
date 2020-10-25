using BarberShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View(Db.GetBookings());
        }

        public IActionResult Info(int id)
        {
            ViewBag.BId = id;
            return View(Db.GetBookings());
        }

        [HttpPost]
        public IActionResult Register(RegisterDetails model)
        {
            if (ModelState.IsValid)
            {
                return View();
            }

            return View(); // error view
        }
    }
}
