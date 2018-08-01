using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    class Program
    {
        static void Main(string[] args)
        {
            string textfile = @"C:\Users\Gabor\source\repos\ConsoleApp50\ConsoleApp50\textfile.txt";
            Console.WriteLine(lineCount(textfile));
            
            Console.ReadLine();
        }
        public static int lineCount(string textfile)
        {
            int counter = 0;
            try
            {
                string[] textfileArray = File.ReadAllLines(textfile);

                for (int i = 0; i < textfileArray.Length; i++)
                {
                    counter++;
                }
                return counter;
            }

            catch (Exception)
            {
                return counter;
            }

                        // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.
        }
    }
}
