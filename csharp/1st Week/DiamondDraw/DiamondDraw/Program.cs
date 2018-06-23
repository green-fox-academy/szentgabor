using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondDraw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add an integer to help me draw an Egyptian pyramid!");
            int a = Int32.Parse(Console.ReadLine());
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was
            if (a % 2 == 0)
            {
                for (int i = 0; i < a / 2; i++)
                {
                    for (int j = 0; j < a / 2 - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k <= i + i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                for (int l = 0; l < a / 2; l++)
                {
                    for (int m = 0; m <= l; m++)
                    {
                        Console.Write(" ");
                    }
                    for (int n = 0; n <= a - 2 - 2 * l; n++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < a / 2 + 1; i++)
                {
                    for (int j = 0; j < a / 2 - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k <= i + i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                for (int l = 0; l < a / 2; l++)
                {
                    for (int m = 0; m <= l; m++)
                    {
                        Console.Write(" ");
                    }
                    for (int n = 0; n < a - 2 - 2 * l; n++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
                    Console.ReadLine();
        }
    }
}