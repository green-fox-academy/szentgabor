using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberGiven = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculator(numberGiven));
            Console.ReadLine();
            // Given a non-negative int n, return the sum of its digits recursively (no loops). 
            // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
            // divide (/) by 10 removes the rightmost digit (126 / 10 is 12).
        }
        public static int Calculator(int n)
        {
            if (n % 10 == 0)
            {
                return 0;
            }
            else
            {
                return Calculator(n / 10) + n % 10;
            }
        }
    }
}