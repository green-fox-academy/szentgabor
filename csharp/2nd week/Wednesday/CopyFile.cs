using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = @"C:\Users\Gabor\Desktop\szentgabor\csharp\2nd week\Wednesday\file1.txt";
            string file2 = @"C:\Users\Gabor\Desktop\szentgabor\csharp\2nd week\Wednesday\file2.txt";
            bool didItSucceed = ;
            Console.WriteLine(SuccessfulCopy(didItSucceed);
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
        }
        static bool SuccessfulCopy
            string[] Lines1 = File.ReadAllLines(file1);
            string[] Lines2 = File.ReadAllLines(file2);

            for (int i = 0; i<Lines1.Length; i++)
            {
                StreamWriter sw = new StreamWriter(file2);
            }
                    if (line<Lines2.Length)(Lines1[line].Equals(Lines2[line]))
            }
            try
            {
                
                
                for (int i = 0; i<file1.Length; i++)
                {
                strw.WriteLine(file1);
                }
            sw.Dispose();
            }

            finally
            {
                
            return SuccessfulCopy
    }
}
