using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Gabor\source\repos\ConsoleApp50\ConsoleApp50\textfile.txt";

            // Write your name in it as a single line
            // If the program is unable to write the file,
            // then it should print an error message like: "Unable to write file: my-file.txt"";
            try
            {
                File.WriteAllText (path, "Szentesi Gabor");
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write current file.");
            }
            // Open a file called "my-file.txt"
            // Write your name in it as a single line
            // If the program is unable to write the file,
            // then it should print an error message like: "Unable to write file: my-file.txt"
        }
    }
}
