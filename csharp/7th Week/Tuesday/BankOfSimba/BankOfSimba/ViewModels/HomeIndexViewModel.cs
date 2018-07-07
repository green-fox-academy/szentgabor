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
            new BankAccount ("Timon", 8000, "surikata", false),
            new BankAccount ("Zazu", 6000, "bird", false),
            new BankAccount ("Nala", 9000, "lion", false),
            new BankAccount ("Pumba", 12000, "boar", false),
            new BankAccount ("Mufasa", 90000, "lion", true)
        };

        public void CheckAnimal(string name)
        {
            foreach (var animal in Accounts)
            {
                if (animal.Name.ToLower().Equals(name.ToLower()))
                {
                    animal.Incrementer();

                    // balance = (int)animal.Balance;
                }
            }
        }
    }


}
