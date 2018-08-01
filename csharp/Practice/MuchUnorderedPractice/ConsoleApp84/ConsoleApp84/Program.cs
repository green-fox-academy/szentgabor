using System;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0

            Console.WriteLine("Add a number to devide by 10: ");

            int input = Int32.Parse(Console.ReadLine());

            Console.WriteLine(DivideTenWith(input));

            Console.ReadLine();

        }

        public static int DivideTenWith(int inputed)
        {
            int reckoner = 10;

            try
            {
                reckoner = reckoner / inputed;
                return reckoner;
            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine(error.Message);
                return 0;
            }
        }
    }
}