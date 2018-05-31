using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a sum method in your class which takes a List of integers as parameter
            // It should return the sum of the elements in the list
        }
        public int SumReturner(List<int> myIntegers)
        {
            int sum = 0;
            for (int i = 0; i < myIntegers.Count; i++)
            {
                sum += myIntegers[i];
            }
            return sum;
        }
    }
}
