using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstPractice.Models
{
    public class Planet
    {
        private SpaceContext spaceContext;

        public Planet(SpaceContext spaceContext)
        {
            this.spaceContext = spaceContext;
        }

        public int Id { get; set; }
        public int SpaceshipId { get; set; }
        public string Name { get; set; }
        public double Population { get; set; }

        public virtual Spaceship Spaceship { get; set; }

        public List<Planet> GetAllPlanets()
        {
            return spaceContext.Planets.Include(b => b.Spaceship).ToList();
        }
    }
}
