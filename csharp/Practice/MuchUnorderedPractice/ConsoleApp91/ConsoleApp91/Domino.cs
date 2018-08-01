using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp91
{
    public class Domino
    {
        private readonly int[] Values;

        public Domino(int ValueA, int ValueB)
        {
            this.Values = new int[] { ValueA, ValueB };
        }

        public int[] GetValues()
        {
            return Values;
        }
    }
}
