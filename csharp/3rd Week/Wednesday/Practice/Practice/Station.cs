using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Station
    {
        public double capacity;
        public double actual;

        public Station(double actual)
        {
            capacity = 1000;
            this.actual = actual;
        }

        public void Refill(Car car)
        {
            if (car.gas == car.capacity)
            {
                throw new Exception("e");
                {
                    Console.WriteLine("The car is full, cannot be refueled.");
                }
            }
            if (actual < 350)
            {
                actual = capacity;
            }
            actual -= car.capacity - car.gas;
            car.gas += car.capacity - car.gas;
        }
    }
}
