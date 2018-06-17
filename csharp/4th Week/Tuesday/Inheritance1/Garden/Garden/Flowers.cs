using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Flowers : GardenPlants
    {
        public Flowers()
        {
            if (WaterLevel < 5)
            {
                NeedsWater = true;
            }
            else
            {
                NeedsWater = false;
            }
            AbsorbtionRate = 0.75;
        }
    }
}
