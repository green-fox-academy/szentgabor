using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Tree : Plant
    {
        public Tree(string name, double waterLevel) : base(name, waterLevel)
        {
            WaterAbsorptionRate = 0.4;
        }

        public override bool NeedWater()
        {
            if (WaterLevel < 10)
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