using System;
using System.Text;

namespace TakesLonger
{
    public class TakesLonger
    {
        public static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";
            // Console.WriteLine(yoloText.Substring(0, 1));
            // quote.Insert(quote.Substring("It", quote.Substring("you");
            StringBuilder quoteBuilder = new StringBuilder(quote);

            quoteBuilder
                .Insert(21, "always takes longer than ");
                
            Console.WriteLine(quoteBuilder);
            Console.ReadLine();

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)

            Console.WriteLine(quote);
        }
    }
}