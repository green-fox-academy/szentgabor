using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_protection
{
    class Cat : Animal
    {
        public Cat() : base()
        {
            Name = "Cat";
            HealCost = Rnd.Next(0, 7);
        }

        public Cat(string name) : base(name)
        {
            HealCost = Rnd.Next(0, 7);
        }
    }
}
