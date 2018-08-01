using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp64
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p1 = {1, 2, 3 };
            int[] p2 = {4, 5, 7, 8 };

            if (p1.Length > p2.Length)
            {
                Console.WriteLine("p1 is longer");
            }
            else if (p1.Length < p2.Length)
            {
                Console.WriteLine("p2 is longer");
            }
            Console.ReadLine();
            // - Create an array variable named `p1`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `p2`
            //   with the following content: `[4, 5]`
            // - Print if `p2` has more elements than `p1`
        }
    }
}
