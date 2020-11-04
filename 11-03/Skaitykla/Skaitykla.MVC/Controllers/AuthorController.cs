using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Skaitykla.Domains;
using Skaitykla.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skaitykla.MVC.Controllers
{
    public class AuthorController : Controller
    {
        private readonly BookContext _db;

        public AuthorController(BookContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            
            return View(_db.Authors.Include(x=>x.WrittenBooks));
        }

        [HttpGet]
        public IActionResult CreateAuthor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAuthor(string name, string surname)
        {
            var newAuthor = new Author(name, surname);

            newAuthor.WrittenBooks.Add(new Book() { Title = "Pasakos", PageCount = 100 });

            _db.Authors.Add(newAuthor);
            _db.SaveChanges();


            return View();
        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            var author = _db.Authors.Where(x => x.Id == id).Single();
            var books = _db.Books.Where(x => x.Author == author).ToList();
            foreach (Book item in books){
                _db.Books.Remove(item);
            }
            _db.Authors.Remove(author);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
