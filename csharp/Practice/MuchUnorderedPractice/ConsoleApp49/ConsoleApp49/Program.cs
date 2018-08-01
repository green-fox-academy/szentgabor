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

            try
            {
                int divisor = int.Parse(Console.ReadLine());
                int result = 10 / divisor;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                  Console.WriteLine("Can't divide by zero!");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}