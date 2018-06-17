using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    abstract class GardenPlants
    {
        string name = "";
        double waterLevel;
        bool needsWater;
        double absorbtionRate;

public string Name { get => name; set => name = value; }
        public double WaterLevel { get => waterLevel; set => waterLevel = value; }
        public bool NeedsWater { get => needsWater; set => needsWater = value; }
        public double AbsorbtionRate { get => absorbtionRate; set => absorbtionRate = value; }
    }
}
