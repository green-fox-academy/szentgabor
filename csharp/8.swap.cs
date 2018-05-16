using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap the values of the variables
            
                int number1, number2, temp;
                number1 = 123;
                number2 = 526;
                Console.WriteLine("Number1 is: " + number1);
                Console.WriteLine("Number2 is: " + number2);
                temp = number1;
                number1 = number2;
                number2 = temp;
                Console.Write("\nAfter Swapping : ");
                Console.Write("\nFirst Number : " + number1);
                Console.Write("\nSecond Number : " + number2);
                Console.Read();
            
        
    }
    }
}