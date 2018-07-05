using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practice.Models;

namespace Practice.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            Greeting greeting = new Greeting(name);
            return new JsonResult(greeting);
        }
    }
}