using System.Text;
using System;

namespace TakesLonger
{
    public class TakesLonger
    {
        public static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)

            StringBuilder quote1 = new StringBuilder();
            quote1.Append(quote);
            for (int i = 0; i < quote.Length - 5; i++)
            {
                if (quote.Substring(i, 6) == "It you")
                {
                    quote1.Insert(i + 2, " always takes longer than");
                }
            }
            Console.WriteLine(quote1.ToString());
            Console.ReadLine();
        }
    }
}