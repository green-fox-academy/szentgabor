using BankOfSimba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.ViewModels
{
    public class HomeIndexViewModel
    {
        //public BankAccount bankAccount { get; set; }
        public List<BankAccount> Accounts = new List<BankAccount>()
        {
            new BankAccount ("Timon", 8000, "surikata"),
            new BankAccount ("Zazu", 6000, "bird"),
            new BankAccount ("Nala", 9000, "lion"),
            new BankAccount ("Pumba", 12000, "boar"),
        };
    }
}
