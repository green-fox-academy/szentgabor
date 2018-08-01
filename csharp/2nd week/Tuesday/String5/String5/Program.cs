using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String5
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!
            char[] reversedArray = reversed.ToArray();
            Array.Reverse(reversedArray);
            Console.WriteLine(new string (reversedArray));
            Console.WriteLine(Reversing(reversed));
        }
        public static string Reversing(string toReverse)
        {
            Char[] reversed = Enumerable.Range(1, toReverse.Length).Select(x => toReverse[toReverse.Length - x]).ToArray();
            return new string(reversed);
        }
    }
}
