﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add an integer to help me draw an Egyptian pyramid!");
            int a = Int32.Parse(Console.ReadLine());

            for (int i = 0; i <= a; i++)
            {
                for (int j = 0; j < a - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}