using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public BankAccount(string name, int balance, string animalType)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
        }

        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string AnimalType { get; set; }

        public string Balancer()
        {
            return $"{Balance} zebra";
        }
    }
}
