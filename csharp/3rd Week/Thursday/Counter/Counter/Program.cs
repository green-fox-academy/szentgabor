using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and counts down from n.
            int n = 50;
            Countdown(n);
            Console.ReadLine();
        }

        public static void Countdown(int ActualNumber)
        {
            if (ActualNumber == 0)
            {
                Console.WriteLine(ActualNumber);
            }

            else if (ActualNumber != 0)
            {
                Console.WriteLine(ActualNumber);
                ActualNumber--;
                Countdown(ActualNumber);
            }     
        }
    }
}
