using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp87
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Name.txt";
            string name = "SzentGabor";
            Name(name);
            string[] checker = File.ReadAllLines(path);
            Console.WriteLine(checker[0]);
            Console.ReadKey();
        }
        public static void Name(string name)
        {
            try
            {
                StreamWriter sw = new StreamWriter("Name.txt");
                sw.Write(name);
                sw.Dispose();
            }
            catch (Exception)
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
