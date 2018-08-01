using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp65
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `r`
            //   with the following content: `[54, 23, 66, 12]`
            // - Print the sum of the second and the third element
            int[] r = { 54, 23, 66, 12 };
            Console.WriteLine(Summer(r));
        }
        public static int Summer(int[]read)
        {
            int sum = 0;
            sum = read[1] + read[2];
            return sum;
        }
    }
}
