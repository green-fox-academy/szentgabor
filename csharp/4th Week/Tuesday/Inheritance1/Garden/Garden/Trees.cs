using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Trees : GardenPlants
    {
        class Flowers : GardenPlants
        {
            public Flowers()
            {
                if (WaterLevel < 10)
                {
                    NeedsWater = true;
                }
                else
                {
                    NeedsWater = false;
                }
            AbsorbtionRate = 0.4;
            }
        }
    }
}
