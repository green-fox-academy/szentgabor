using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Macrotis.Models
{
    public class Attraction
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public double Longitude { get; set; }
        public double Lattitude { get; set; }
        public int RecommendedAge { get; set; }
        public int Duration { get; set; }
    }
}
