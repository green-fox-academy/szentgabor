using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix.Models
{
    public class Matrixx
    {
        public int ID { get; set; }
        public string MatrixArray { get; set; }
        public DateTime CreatedDate { get; set; }

        public Matrixx()
        {
            this.CreatedDate = DateTime.UtcNow;
        }
    }
}
