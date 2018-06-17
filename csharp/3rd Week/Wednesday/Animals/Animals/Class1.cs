using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animals
    {
        public int hunger;
        public int thirst;

        public Animals()
        {
            hunger = 50;
            thirst = 50;
        }

        public Animals(int hunger, int thirst)
        {
            this.hunger = hunger;
            this.thirst = thirst;
        }

        public void Eat()
        {
            hunger--;
        }

        public void Drink()
        {
            thirst--;
        }

        public void Play()
        {
            hunger++;
            thirst++;
        }
    }
}
