using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_protection
{
    abstract class Animal
    {
        private string name;
        private bool isHealthy;
        private double healCost;
        private Random rnd = new Random();


        public string Name { get => name; set => name = value; }
        public bool IsHealthy { get => isHealthy; set => isHealthy = value; }
        public double HealCost { get => healCost; set => healCost = value; }
        public Random Rnd { get => rnd; set => rnd = value; }

        public Animal(string name)
        {
            this.name = name;
        }

        public Animal()
        {
        }

        public void Heal()
        {
            isHealthy = true;
        }

        public bool IsAdoptable()
        {
            return isHealthy;
        }

        public new string ToString()
        {
            if (isHealthy)
            {
                return $"{Name} is healthy and adoptable.";
            }
            else
            {
                return $"{Name} is not healthy, and not adoptable, healing cost is {HealCost}.";
            }
        }
    }
}
