using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int km;
            km = Int32.Parse(Console.ReadLine());
            double mile;
            mile = 1.6;
            Console.Write("Please add a distance in km (integer): ");
            Console.WriteLine("Your distance in mile is: {0}", km / mile);
            Console.ReadLine();

            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it
        }
    }
}