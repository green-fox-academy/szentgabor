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
            try
            {
                StreamWriter strw = new StreamWriter(path);
                Console.WriteLine("Give me a word: ");
                string word = Console.ReadLine();
                Console.WriteLine("Give me a number: ");
                int number = Int32.Parse(Console.ReadLine());

                for (int i = 0; i < number; i++)

                {
                    strw.WriteLine(word);
                }

                strw.Dispose();
                Console.ReadLine();
            }

            catch (Exception)
            {
                Console.WriteLine("");

            }
        }
    }
}