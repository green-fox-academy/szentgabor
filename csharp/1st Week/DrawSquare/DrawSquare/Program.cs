using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add me a number: ");
            int a = Int32.Parse(Console.ReadLine());

            for (int i = 0; i <= a; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < a; j++)
                    {
                        Console.Write("%");
                    }
                    Console.WriteLine();
                }
                else if (i > 0 && i < a - 1)
                {
                    Console.Write("%");
                    for (int j = 1; j < a - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("%");
                    Console.WriteLine();
                }
                else if (i == a - 1)
                {
                    for (int k = 1; k <= a; k++)
                    {
                        Console.Write("%");
                    }
                }
            }
            Console.ReadLine();
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %   %
            // %   %
            // %   %
            // %   %
            // %%%%%
            //
            // The square should have as many lines as the number was
        }
    }
}
