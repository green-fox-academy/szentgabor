using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please add a number (integer): ");
            int first;
            first = Int32.Parse(Console.ReadLine());

            Console.Write("Add another number (integer): ");
            int second;
            second = Int32.Parse(Console.ReadLine());

            Console.Write("Add another number(integer): ");
            int third;
            third = Int32.Parse(Console.ReadLine());

            Console.Write("Add another number (integer): ");
            int fourth;
            fourth = Int32.Parse(Console.ReadLine());

            Console.Write("Add another number (integer): ");
            int fifth;
            fifth = Int32.Parse(Console.ReadLine());

            Console.WriteLine("The sum of the numbers you gave is: {0}", first + second + third + fourth + fifth);
            Console.WriteLine("Whilst the average of the numbers you gave is: {0}", (first + second + third + fourth + fifth) / 5);
            
            Console.ReadLine();
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
        }
    }
}