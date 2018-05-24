using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int Base = 4;
            int Power = 3;
            PowerPlay(Base,Power);
            Console.WriteLine(PowerPlay(Base,Power));
            Console.ReadLine();

            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).
        }
        public static int PowerPlay(int n, int k)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return k * PowerPlay(n-1, k);
            }
        }
    }
}
