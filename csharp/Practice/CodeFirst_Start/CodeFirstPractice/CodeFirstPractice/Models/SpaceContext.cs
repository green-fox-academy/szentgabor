using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstPractice.Models
{
    public class SpaceContext : DbContext
    {

        public DbSet<Planet> Planets { get; set; }
        public DbSet<Spaceship> Spaceship { get; set; }

        public SpaceContext(DbContextOptions<SpaceContext> options) : base(options)
        {
        }

    }
}
