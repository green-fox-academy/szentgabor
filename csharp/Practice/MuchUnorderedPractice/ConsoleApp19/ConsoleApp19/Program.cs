using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add the number of boys at the party!");
            int number1;
            number1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please add the number of girls at the party!");
            int number2;
            number2 = Int32.Parse(Console.ReadLine());

            if (number1 == number2 && number1+number2 > 20)
            {
                Console.WriteLine("The party is excellent!");
                    }
            if (number1 != number2 && number1 + number2 > 20 && number2 > 0)
            {
                Console.WriteLine("The party is quite cool!");
            }

            if (number1 + number2 < 20)
            {
                Console.WriteLine("The party is average.");
            }

            if (number2 == 0)
            {
                Console.WriteLine("Sausage party");
            }

            Console.ReadLine();
            
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people
        }
    }
}