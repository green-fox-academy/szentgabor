﻿using System;
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
            if (distance / 13 > gas)
            {
                throw new Exception("The car needs more fuel for such a distance.");
            }
            gas -= distance / 13;
        }
    }
}

