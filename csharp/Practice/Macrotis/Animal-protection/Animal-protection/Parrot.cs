using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_protection
{
    class Parrot : Animal
    {
        public Parrot()
        {
            Name = "Parrot";
            HealCost = Rnd.Next(4, 11);
        }

        public Parrot(string name) : base(name)
        {
            HealCost = Rnd.Next(4, 11);
        }
    }
}
