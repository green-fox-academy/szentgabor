using System;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(ReverseIt(reversed));
            Console.ReadLine();
        }
        public static string ReverseIt(string reversed)
        {
            string reverseWords = "";

            for (int i = reversed.Length - 1 ; i >= 0; i--)
            {
                reverseWords += reversed[i];
            }
            return reverseWords;
        }
    }
}