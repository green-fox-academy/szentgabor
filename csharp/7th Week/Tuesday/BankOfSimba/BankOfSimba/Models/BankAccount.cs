using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public static int IDCounter = 1;

        public BankAccount(string name, int balance, string animalType, bool isKing)
        {
            ID = IDCounter;
            IDCounter++;
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            IsKing = isKing;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string AnimalType { get; set; }
        public bool IsKing { get; set; }

        public string Balancer()
        {
            return $"{Balance} zebra";
        }

        public void Incrementer()
        {
            if (!IsKing)
            {
                Balance += 10;
            }
            else
            {
                Balance += 100;
            }
        }
    }
}
