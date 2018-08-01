using System;

namespace Doubling
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNum;
            baseNum = 123;

            Console.WriteLine(doubling(baseNum));
            Console.ReadLine();
        }
        static int doubling (int Num1)
        {
            return Num1 * Num1;
        }
            // - Create an integer variable named `baseNum` and assign the value `123` to it
            // - Create a function called `doubling` that doubles it's input parameter and returns with an integer
            // - Print the result of `doubling(baseNum)`
            }
    }
