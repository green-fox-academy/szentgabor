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
            bool didItSucceed = true;
            Console.WriteLine(SuccessfulCopy(file1, file2, didItSucceed));
            Console.ReadLine();
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
        }
        public static bool SuccessfulCopy(string file1, string file2, bool valami)
        {
            try
            {
                StreamWriter sw = new StreamWriter(file2);
                string[] Lines1 = File.ReadAllLines(file1);
                
                foreach (var item in Lines1)
                {
                    sw.WriteLine (item);
                    // az az írófunkció kell, amivel hozzáadom (nem mindig felülírja a már átírtat)
                }
                sw.Dispose();

                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }// if (line<Lines2.Length)(Lines1[line].Equals(Lines2[line])
    }
}
