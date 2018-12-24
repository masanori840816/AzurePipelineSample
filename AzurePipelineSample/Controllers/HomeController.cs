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
    }
}
