using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreetSomeone.Services;
using Microsoft.AspNetCore.Mvc;

namespace GreetSomeone.Controllers
{
    public class GreetingsController : Controller
    {
        private IGreetings igreetings;

        public GreetingsController(IGreetings greetings)
        {
            igreetings = greetings;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/")]
        public IActionResult Second(string name)
        {
            igreetings.SetName(name);
            return RedirectToAction("Third");
        }
        
        [HttpGet]
        [Route("/greet")]
        public IActionResult Third()
        {
            object nev = igreetings.GetName();
            return View(nev);
        }
    }
}