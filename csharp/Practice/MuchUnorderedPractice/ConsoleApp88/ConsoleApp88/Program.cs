using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp88
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\users\gabor\source\repos\ConsoleApp88\ConsoleApp88\copy.txt";
            string copied = @"c:\users\gabor\source\repos\ConsoleApp88\ConsoleApp88\copied.txt";
            Console.WriteLine(Copied(path, copied));
            Console.ReadLine();
        }
        public static bool Copied(string file, string fileCopy)
        {
            try
            {
                string[] copiedLines = File.ReadAllLines(file);
                StreamWriter sw = new StreamWriter(fileCopy);
                foreach (string item in copiedLines)
                {
                    sw.WriteLine(item);
                }
                sw.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
