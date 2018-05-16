using System;

namespace CompareLength
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p1 = { 1, 2, 3 };
            int[] p2 = { 4, 5, 5, 7 };

            if (p1.Length < p2.Length)
            {
                Console.WriteLine("The p2 array is longer than the p1!");
            }
            // - Create an array variable named `p1`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `p2`
            //   with the following content: `[4, 5]`
            // - Print if `p2` has more elements than `p1`
            Console.ReadLine();
        }
    }
}
