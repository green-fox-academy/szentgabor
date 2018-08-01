using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp70
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `ai`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Print the sum of the elements in `ai`
            int[] ai = { 3, 4, 5, 6, 7 };
            Console.WriteLine(SumReturner(ai));
            Console.ReadLine();
        }
        static int SumReturner(int[] original)
        {
            int sum = 0;
            for (int i = 0; i < original.Length; i++)
            {
                sum += original[i];
            }
            return sum;
        }
    }
}
