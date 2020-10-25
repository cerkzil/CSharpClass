using Microsoft.AspNetCore.Mvc;
using Skaitykla.Domains;
using Skaitykla.MVC.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Skaitykla.MVC.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewBook()
        {
            var myAuthorList = new List<Author>() {
                    new Author("Stephen", "King"),
                    new Author("Salomeja", "Neris")
            };


            return View(myAuthorList);
        }


        [HttpPost]
        public IActionResult NewBook(NewBookViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.AuthError = "ivyko klaida";
                return RedirectToAction("Index", "Auath");
            }

            var myNewBook = new Book
            {
                Title = model.Title,
                // Author = _db.authors.where(Author => )

            };




            Db.Save();
            return RedirectToAction("NewBook");
        }
    }
}
