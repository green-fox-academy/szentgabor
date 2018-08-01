using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp80
{
    class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code
            // Create a method called QuoteSwap().

            // Also, print the sentence to the output with spaces in between.
            Console.WriteLine(QuoteSwap(list));
            Console.ReadLine();
            // Expected output: "What I cannot create I do not understand." 
        }
        public static string QuoteSwap(List<string> sentence)
        {
            int indexOne = sentence.IndexOf("do");
            int indexTwo = sentence.IndexOf("cannot");

            string temp = string.Empty;
            temp = sentence[indexOne];
            sentence[indexOne] = sentence[indexTwo];
            sentence[indexTwo] = temp;

            string outPutString = string.Empty;

            for (int k = 0; k < sentence.Count; k++)
            {
                outPutString += sentence[k] + " ";
            }
            return outPutString;
        }
    }
}

