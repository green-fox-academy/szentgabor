using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Macrotis.Models
{
    public class AttractionContext : DbContext
    {
        public DbSet<Attraction> Attractions { get; set; }

        public AttractionContext(DbContextOptions<AttractionContext> options) : base(options)
        {
        }
    }
}
