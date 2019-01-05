using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzurePipelineSample.Models;
using Microsoft.AspNetCore.Mvc;

namespace AzurePipelineSample.Controllers
{
    public class HomeController: Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            ViewData["SampleUsers"] = Enumerable.Range(0, 5)
                .Select(num => new User
                {
                    ID = num,
                    Name = "User " + num,
                    Description = "Hello World!!!"
                })
                .ToList();
            return View("/Views/Index.cshtml");
        }
        [Produces("application/json")]
        [Route("users/all")]
        public List<User> GetAllUsers()
        {
            return new List<User>
            {
                new User
                {
                    ID = 0,
                    Name = "Hello",
                },
                new User
                {
                    ID = 1,
                    Name = "World",
                },
                new User
                {
                    ID = 2,
                    Name = "!",
                }
            };
        }
    }
}
