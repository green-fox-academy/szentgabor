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
            int k = 1;
            int l = 0;
            Countup(n,k,l);
            Console.ReadLine();
        }

        public static void Countup(int ActualNumber, int AddedNumber, int HelperNumber)
        {
            if (ActualNumber > AddedNumber)
            {
                HelperNumber = HelperNumber + AddedNumber;
                ++AddedNumber;
                Countup(ActualNumber, AddedNumber, HelperNumber);
            }

            else if (ActualNumber == AddedNumber)
            {
                ActualNumber = ActualNumber + HelperNumber;
                Console.WriteLine(ActualNumber);
            }
        }
    }
}
