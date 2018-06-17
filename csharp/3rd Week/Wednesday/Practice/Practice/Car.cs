using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Car
    {
        public double capacity;
        public double gas;

        public Car(double gas)
        {
            capacity = 50;
            this.gas = gas;
        }

        public void Drive(double distance)
        {
            gas -= distance / 13;
            if (distance / 13 > gas)
            {
                throw new Exception("f");
                {
                    Console.WriteLine("The car needs more fuel for such a distance.");
                }
            }
        }
    }
}

