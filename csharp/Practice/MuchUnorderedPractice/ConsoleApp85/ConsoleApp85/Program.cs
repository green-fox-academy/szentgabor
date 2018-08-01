using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp85
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"MyFile.txt";
            try
            {
                Console.WriteLine(File.ReadAllText(path));
            }
            catch (FileNotFoundException notFound)
            {
                Console.WriteLine("File not found.");
                Console.WriteLine(notFound.Message);
            }
            Console.ReadLine();
            // Write a program that opens a file called "my-file.txt", then prints
            // each of lines form the file.
            // If the program is unable to read the file (for example it does not exists),
            // then it should print an error message like: "Unable to read file: my-file.txt"
        }
    }
}
