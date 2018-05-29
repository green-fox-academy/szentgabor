using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp61
{
    class Human
    {
        private string name;
        private int id;
        private static int population = 0;

        public Human(string name, int id)
        {
            this.name = name;
            this.id= id;
            population++;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
        // ez egy property, ugyanazt meg lehet csinálni, mint a field + method módon

        public static int Population
        {
            get
            {
                return population;
            }
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }
    }
}
