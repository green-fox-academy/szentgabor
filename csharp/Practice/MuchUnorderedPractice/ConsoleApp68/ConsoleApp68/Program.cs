using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp68
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Try to guess my number!");
            Messages();
            Console.ReadLine();
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stored number is lower
            // You found the number: 8
        }
        public static void Messages()
        {
            int numberToGuess = 8;
            int guessed = Int32.Parse(Console.ReadLine());
            if (guessed > numberToGuess)
            {
                Console.WriteLine("The stored number is lower, try again.");
                Messages();
            }
            else if (guessed < numberToGuess)
            {
                Console.WriteLine("The stored number is higher, try again.");
                Messages();
            }
            if (guessed == numberToGuess)
            {
                Console.WriteLine("You've found the number: 8.");
            }
        }
    }
}
