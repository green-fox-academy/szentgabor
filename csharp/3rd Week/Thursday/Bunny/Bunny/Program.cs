using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunny
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies 
            // recursively (without loops or multiplication).
            int bunnyNumber = 1;
            Console.WriteLine(BunnyCounter(bunnyNumber));
            Console.ReadLine();
        }
        public static int BunnyCounter(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return BunnyCounter(n - 1) + 2;
            }

        }
    }
}