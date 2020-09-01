using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace smartplace.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("/Pages/Login/login.cshtml");
        }

        [Route("/register")]
        public IActionResult Register()
        {
            return View("/Pages/Login/register.cshtml");
        }
    }
}
