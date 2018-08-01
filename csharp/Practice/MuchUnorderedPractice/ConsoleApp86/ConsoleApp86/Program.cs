using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp86
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Circle.txt";

            Console.WriteLine(Counter(path));
            Console.ReadLine();
        }
        public static string Counter(string file)
        {
            try
            {
                string[] array = File.ReadAllLines(file);
                int counter = 0;
                foreach (var item in array)
                {
                    counter++;
                }
                return counter.ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("");
                return "";
            }
        }
    }
}
