using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I won't cheat on the exam!");
            int a = 0;
            do
            {
                Console.WriteLine("I won't cheat on the exam!");
                a ++;
            }

            while (a < 101);

            Console.ReadLine();
                 
            // Create a program that writes this line 100 times:
            // "I won't cheat on the exam!"
        }
    }
}