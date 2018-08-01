using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Macrotis.Models;
using Macrotis.Services;
using Microsoft.AspNetCore.Mvc;

namespace Macrotis.Controllers
{
    public class AttractionController : Controller
    {
        private AttractionServices attractionService;

        public AttractionController(AttractionServices attractionService)
        {
            this.attractionService = attractionService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("gettable")]
        public IActionResult GetTable()
        {
            return View(attractionService.GetAttractions());
        }

        [HttpPost("gettable")]
        public IActionResult AddAttraction(Attraction attraction)
        {
            attractionService.CreateAttraction(attraction);
            return RedirectToAction("gettable");
        }
    }
}