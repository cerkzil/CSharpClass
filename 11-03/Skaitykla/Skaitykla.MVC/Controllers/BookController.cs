using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using Skaitykla.Domains;
using Skaitykla.EF;
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
        private readonly BookContext _db;

        public BookController(BookContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            var manoKnygos = _db.Books.ToList();
            return View(manoKnygos);
        }

        [HttpGet]
        public IActionResult NewBook()
        {
            var authorList = _db.Authors.ToList();

            return View(authorList);
        }


        [HttpPost]
        public IActionResult NewBook(NewBookViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.AuthError = "Something went wrong";
                return RedirectToAction("Index", "Auth");
            }

            var myNewBook = new Book
            {
                Title = model.Title,
                Author = _db.Authors.Where(x => x.Id == model.AuthorId).Single()

            };

            _db.Books.Add(myNewBook);
            _db.SaveChanges();

            return RedirectToAction("NewBook");
        }
    }
}
