using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarberShop.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BarberShop.Controllers
{
    [Route("api/[controller]")]
    public class RegistrationController : Controller
    {
        // POST api/<controller>
        [HttpPost]
        public ActionResult Post([FromBody]string newRegistration)
        {
            RegistrationResult result = new RegistrationResult();

            result.Success = true;

            return Ok(result);
        }
    }
}
