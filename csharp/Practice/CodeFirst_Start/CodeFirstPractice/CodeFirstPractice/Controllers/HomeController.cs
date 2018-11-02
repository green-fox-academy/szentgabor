using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodeFirstPractice.Models;

namespace CodeFirstPractice.Controllers
{
    public class HomeController : Controller
    {
        private SpaceContext spaceContext;

        public HomeController(SpaceContext spaceContext)
        {
            this.spaceContext = spaceContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            return Json(spaceContext.Planets.ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
