using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_protection
{
    class Dog : Animal
    {
        public Dog()
        {
            Name = "Dog";
            HealCost = Rnd.Next(1, 9);
        }

        public Dog(string name) : base(name)
        {
            HealCost = Rnd.Next(1, 9);
        }
    }
}
