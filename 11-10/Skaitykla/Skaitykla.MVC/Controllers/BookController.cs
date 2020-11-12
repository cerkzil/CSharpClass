using Microsoft.AspNetCore.Mvc;
using Skaitykla.Domains;
using Skaitykla.MVC.Models;
using Skaitykla.Services.Interfaces;
using System.Threading.Tasks;

namespace Skaitykla.MVC.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;

        public BookController(IBookService bookService, IAuthorService authorService)
        {
            _bookService = bookService;
            _authorService = authorService;
        }

        public IActionResult Index()
        {
            return View(_bookService.GetBooks());
        }

        [HttpGet]
        public async Task<IActionResult> NewBook()
        {
            return View(await _authorService.GetAuthorsAsync());
        }


        [HttpPost]
        public IActionResult NewBook(NewBookViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.AuthError = "ivyko klaida";
                return RedirectToAction("Index", "Auth");
            }

            var myNewBook = new Book
            {
                Title = model.Title,
                Author = _authorService.GetAuthorById(model.AuthorId)
            };

            var bookId = _bookService.CreateBook(myNewBook);

            return RedirectToAction("NewBook");
        }
    }
}
