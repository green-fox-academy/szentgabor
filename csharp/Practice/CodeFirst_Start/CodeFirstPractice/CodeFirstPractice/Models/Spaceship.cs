using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstPractice.Models
{
    public class Spaceship
    {
        private SpaceContext spaceContext;

        public Spaceship(SpaceContext spaceContext)
        {
            this.spaceContext = spaceContext;
        }

        public int Id { get; set; }
        public int PassengersOnBoard { get; set; }
        public int Capacity { get; set; }
        public virtual Planet Planet { get; set; }

        public Spaceship(int capacity)
        {
            Capacity = 60;
        }

        public List<Spaceship> GetSpaceship()
        {
            return spaceContext.Spaceship.Include(b => b.Planet).ToList();
        }
    }
}
