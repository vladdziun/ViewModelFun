using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            string message = "Hello!";

            return View("Index", message);
        }

        [Route("numbers")]
        [HttpGet]
        public IActionResult Numbers()
        {
            int[] numbers = {1,2,3,4,5,6};

            return View("Numbers", numbers);
        }

        [Route("user")]
        [HttpGet]
        public IActionResult User()
        {
            User user = new User();
            user.FirstName = "Vlad";
            user.LastName = "Dziun";

            return View("User", user);
        }

        [Route("users")]
        [HttpGet]
        public IActionResult Users()
        {
            User user = new User()
            {
                FirstName = "Sasha",
                LastName = "Loh"
            };
            User anotherUser = new User()
            {
                FirstName = "Kolya",
                LastName = "Jmih"
            };
            List<User> myUsers = new List<User>()
            {
                user,
                anotherUser
            };

            return View("Users", myUsers);
        }
    }
}
