using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using smartplace.Models;

namespace smartplace.Controllers.Login
{
    [Route("[Controller]")]
    public class RegisterController : Controller
    {

        private readonly UserContext _context;

        public RegisterController(UserContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View("/Pages/Login/register.cshtml");
        }

        [HttpPost]
        public async Task<ActionResult<User>> Create([FromForm] User user)
        {
            try
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
