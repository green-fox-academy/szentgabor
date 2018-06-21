using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Plant
    {
        string name;
        double waterLevel;
        bool needsWater;
        double waterAbsorptionRate;

        public Plant(string name, double waterLevel)
        {
            this.name = name;
            this.waterLevel = waterLevel;
            needsWater = false;
        }

        public double WaterLevel { get => waterLevel; set => waterLevel = value; }
        public bool NeedsWater { get => needsWater; set => needsWater = value; }
        public double WaterAbsorptionRate { get => waterAbsorptionRate; set => waterAbsorptionRate = value; }
        public string Name { get => name; set => name = value; }

        public virtual bool NeedWater()
        {
            return needsWater;
        }

        public virtual double GetWater(double water)
        {
            return water;
        }
    }
}
