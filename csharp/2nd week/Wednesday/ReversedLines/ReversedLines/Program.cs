using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReversedLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\AG\Green Fox Academy\szentgabor\csharp\2nd week\Wednesday\ReversedLines\ReversedLines\toReverse.txt";
            Console.WriteLine(Reversed(path));
            Console.ReadLine();
        }
        public static string Reversed(string rev)
        {
            string[] reverse = File.ReadAllLines(rev);
            string temp = "";
            for (int i = 0; i < reverse.Length; i++)
            {
                for (int j = reverse[i].Length - 1; j >= 0; j--)
                {
                    temp += reverse[i][j];
                }
                temp += "\n";
            }
            StreamWriter sw = new StreamWriter("reversed.txt");
            sw.WriteLine(temp);
            sw.Dispose();
            return temp;
        }
    }
}
