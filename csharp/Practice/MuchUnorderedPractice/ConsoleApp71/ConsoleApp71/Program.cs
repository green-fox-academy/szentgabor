using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp71
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 11, 13, 5, 5, 13, 7, 8, 8, 9 };
            //  Create a function that takes a list of numbers as a parameter
            //  Returns a list of numbers where every number in the list occurs only once
            numbers = ListOptimizer(numbers);
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
        }
        static List<int> ListOptimizer(List<int> original)
        {
            List<int> get = new List<int> { };
            for (int i = 0; i < original.Count; i++)
            {
                for (int j = 0; j < get.Count; j++)
                {
                    if (original[i] != get[j])
                    {
                        get[j] += original[i];
                    }
                }
            }
            return get;
        }
    }
}
