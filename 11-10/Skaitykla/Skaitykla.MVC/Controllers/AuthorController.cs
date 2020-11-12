using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Skaitykla.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace Skaitykla.MVC.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService _service;
        private readonly ILogger<AuthorController> _logger;
     
        public AuthorController(IAuthorService service, ILogger<AuthorController> logger)
        {
            _service = service;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_service.GetAuthorsAsync());
        }

        [HttpGet]
        public IActionResult CreateAuthor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAuthor(string name, string surname)
        {
            try
            {
                _service.CreateAuthorAsync(name, surname);
            }
            catch (Exception ex)
            {
                _logger.LogError("suluzo create author", ex);
                return RedirectToAction("error");
            }

            return RedirectToAction("CreateAuthor");
        }

        public IActionResult Edit(Guid id)
        {
            return View(_service.GetAuthorById(id));
        }
    }
}
