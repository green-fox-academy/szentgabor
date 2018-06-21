using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Garden
    {
        public void Watering(List<Plant> plants, double water)
        {
            int counter = 0;
            foreach (Plant item in plants)
            {
                if (item.NeedWater())
                {
                    counter++;
                }
            }
            foreach (Plant item in plants)
            {
                if (item.NeedWater())
                {
                    item.WaterLevel = item.WaterLevel + water / counter * item.WaterAbsorptionRate;
                }
            }
        }

        public void Status(List<Plant> plants)
        {
            foreach (Plant item in plants)
            {
                if (item.NeedWater())
                {
                    Console.WriteLine($"The {item.Name} {item.GetType().Name} needs water.");
                }
                else
                {
                    Console.WriteLine($"The {item.Name} {item.GetType().Name} does not need water.");
                }
            }
        }
    }
}
