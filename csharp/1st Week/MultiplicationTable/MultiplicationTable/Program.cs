using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer.");
            int a = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i + " * " + a + " = " + i * a);
            }
        }
    }
}
