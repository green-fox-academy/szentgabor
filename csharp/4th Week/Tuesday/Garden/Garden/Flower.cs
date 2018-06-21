using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Flower : Plant
    {
        public Flower(string name, double waterLevel) : base(name, waterLevel)
        {
            WaterAbsorptionRate = 0.75;
        }

        public override bool NeedWater()
        {
            if (WaterLevel < 5)
            {
                NeedsWater = true;
                return NeedsWater;
            }
            else
            {
                return false;
            }
        }
        
        public override double GetWater(double water)
        {
            double absorbedWater = water * WaterAbsorptionRate;
            return absorbedWater;
        }
    }
}
