using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;
using BankOfSimba.ViewModels;

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("simba")]
        public IActionResult Animalizer()
        {
            BankAccount bankAccount = new BankAccount("Simba", 2000, "lion");
            return View(bankAccount);
        }

        public static HomeIndexViewModel lister = new HomeIndexViewModel();

        [Route("animal")]
        public IActionResult AnimalAccounts()
        {
            lister.Accounts.Add(new BankAccount ("Rafiki", 7500, "mandrill" ));
            return View(lister);
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
