using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial
            Console.ReadLine();
            int Num;
            Num = 6;

            Console.WriteLine(factorio(Num));
            Console.ReadLine();
        }
        public static int factorio(int Num1)
        {
            int fact = 1;
            for (int i = 1; i <= Num1; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}