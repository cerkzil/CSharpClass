using Microsoft.AspNetCore.Mvc;
using Skaitykla.Domains;
using Skaitykla.MVC.Models;
using Skaitykla.Services.Interfaces;

namespace Skaitykla.MVC.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowBookController : Controller
    {
        private readonly ILendingService _lendingService;

        public BorrowBookController(ILendingService lendingService)
        {
            _lendingService = lendingService;
        }

        // POST: api/BorrowBook
        [HttpPost]
        public ActionResult Post([FromBody]BorrowViewModel model)
        {
            if (ModelState.IsValid)
            {
                User userWhoWantsToBorrowBook = new User() { Email = "aurimas@test", Password = "pass", IsAdmin = true };
                LendingBook lended = _lendingService.BorrowBook(model.Id, userWhoWantsToBorrowBook);
                return Ok(lended);
            }
            return Accepted();
        }
    }
}
