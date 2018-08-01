using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Models
{
    public class MemeController : Controller
    {
        public IActionResult Index()
        {
            Meme dankest = new Meme(0, "Harry Potter", "mi");
            return View();
        }
    }
}