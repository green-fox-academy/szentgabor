using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter and returns with an integer
            int Num;
            Num = 12;

            Console.WriteLine(sum(Num));
            Console.ReadLine();
        }
        static int sum(int Num1)
        {
            int sum = 0;
            for (int i = 0; i <= Num1; i++)
            {
                sum += i;
            }
            return sum;
         }
    }
    }
