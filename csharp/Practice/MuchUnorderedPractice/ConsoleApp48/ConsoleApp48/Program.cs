using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstSolution();
        }
        public static void FirstSolution()
        {
            
            StreamReader sw = new StreamReader("file.txt");
            string data = sw.ReadLine();
            Console.WriteLine(data);
            Console.ReadLine();
            
        }
    }
}
