using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp66
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print all the elements of `numbers`
            int[] numbers = {4, 5, 6, 7};
            Printer(numbers);
            Console.ReadLine();
        }
        public static void Printer(int[] printt)
        {
            for (int i = 0; i < printt.Length; i++)
            {
                Console.WriteLine(printt[i]);
            }
        }
    }
}
