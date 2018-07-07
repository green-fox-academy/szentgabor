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
        static HomeIndexViewModel model = new HomeIndexViewModel();

        public IActionResult Index()
        {
            return View();
        }

        [Route("simba")]
        public IActionResult Animalizer()
        {
            BankAccount bankAccount = new BankAccount("Simba", 2000, "lion", true);
            return View(bankAccount);
        }

        // HomeIndexViewModel lister = new HomeIndexViewModel();

        [Route("animal")]
        public IActionResult AnimalAccounts()
        {
            // lister.Accounts.Add(new BankAccount ("Rafiki", 7500, "mandrill" ));
            return View(model);
        }

        [HttpPost]
        [Route("stat")]
        public IActionResult BalanceState(string name)
        {
            if (name == null)
            {
                return RedirectToAction("AnimalAccounts");
            }
            // var balance = 0;
            model.CheckAnimal(name);
               
            return RedirectToAction("AnimalAccounts");
        }

        [HttpGet]
        [Route("increment")]
        public IActionResult Incrementer()
        {
            return View();
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(string name, int balance, string animalType, bool isKing)
        {
            model.Accounts.Add(new BankAccount ( name, balance, animalType, isKing ));
            return RedirectToAction("Animalaccounts");
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
