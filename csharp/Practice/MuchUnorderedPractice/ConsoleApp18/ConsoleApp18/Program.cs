using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add an integer number!");
            int number1;
            number1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please add another integer number!");
            int number2;
            number2 = Int32.Parse(Console.ReadLine());

            if (number1 < number2)
            {
                Console.WriteLine(number2);
            }
            if (number1 > number2)
            {
                Console.WriteLine(number1);
            }
            Console.ReadLine();
            // Write a program that asks for two numbers and prints the bigger one
        }
    }
}