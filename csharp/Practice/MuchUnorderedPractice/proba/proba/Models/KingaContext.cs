using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proba.Models
{
    public class KingaContext : DbContext
    {
        public DbSet<Kinga> Kingas { get; set; }
        public KingaContext(DbContextOptions<KingaContext> options) : base(options)
        {
        }


    }
}
