using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
            int n = 50;
            Countup(n);
            Console.ReadLine();
        }

        public static void Countup(int ActualNumber)
        {
            if (ActualNumber == 0)
            {
                Console.WriteLine(ActualNumber);
            }

            else if (ActualNumber != 0)
            {
                Console.WriteLine(ActualNumber);
                ActualNumber--;
                Countup(ActualNumber);
            }
        }
    }
}
