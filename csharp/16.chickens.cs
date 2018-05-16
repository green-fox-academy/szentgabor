using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please add the number of chickens the farmer owns (integer): ");
            int chickens;
            chickens = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Add the number of the pigs of the farmer: ");
            int pigs;
            pigs = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("The number of total legs the farmer has is: {0}", 4 * pigs + 2 * chickens);
            Console.ReadLine();
            
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have
        }
    }
}