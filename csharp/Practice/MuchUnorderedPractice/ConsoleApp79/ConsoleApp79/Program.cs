using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp79
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };

            // Check if list contains all of the following elements: 4,8,12,16
            // Create a method that accepts list as an input
            // it should return "true" if it contains all, otherwise "false"
            Console.WriteLine(CheckNums(list));
        }
        public static bool CheckNums(List<int> list)
        {
            int counter = 0;
            bool contains = false;
            List<int> checker = new List<int> { 4, 8, 12, 16 };
            for (int i = 0; i < checker.Count; i++)
            {
                if (list.Contains(checker[i]))
                {
                    counter++;
                }
            }
            if (counter == checker.Count)
            {
                contains = true;
                return contains;
            }
            else
            {
                return contains;
            }
        }
    }
}
