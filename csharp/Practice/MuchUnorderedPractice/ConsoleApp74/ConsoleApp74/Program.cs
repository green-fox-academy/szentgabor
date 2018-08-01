using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp74
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(Reverse(reversed));

            Console.WriteLine(ReverseBuilder(reversed).ToString());
            Console.ReadLine();
        }
        public static string Reverse(string sth)
        {
            string reallyReversed = string.Empty;
            for (int i = sth.Length - 1; i >= 0; i--)
            {
                reallyReversed += sth[i];
            }
            return reallyReversed;
        }
        public static StringBuilder ReverseBuilder(string sth)
        {
            StringBuilder stringBuilder = new StringBuilder();
            // stringBuilder.Append(sth);
            for (int i = sth.Length - 1; i >= 0; i--)
            {
                stringBuilder.Insert(sth.Length - i - 1, sth[i]);
            }
            return stringBuilder;
        }
    }
}
