﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountFromTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add a number: ");
            int number1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please add another number: ");
            int number2= Int32.Parse(Console.ReadLine());

            if (number2 > number1)
            {
                Console.WriteLine("The second number is bigger");
            }

            else if (number1 > number2)
            {
                int number3 = number2;
                for (int i = 0; i < number1 - number2; i++)
                {
                    Console.WriteLine(number3);
                    number3++;
                }
            }
            Console.ReadLine();
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5
        }
    }
}
