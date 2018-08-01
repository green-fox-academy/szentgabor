using System;
using System.Text;

namespace TodoPrint
{
    public class TodoPrint
    {
        public static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indentation
            StringBuilder quoteBuilder = new StringBuilder(todoText);

            quoteBuilder
                .Insert(0, "My todo:\n")
                .Append(" - Download games\n")
                .Append("/t - Diablo");


            // Console.WriteLine(quoteBuilder);


            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            Console.WriteLine(quoteBuilder);
            Console.ReadLine();
        }
    }
}