using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix.Models
{
    public class MatrixContext : DbContext
    {
        public DbSet<Matrixx> Matrixes { get; set; }

        public MatrixContext(DbContextOptions<MatrixContext> options) : base(options)
        {
        }
    }
}
