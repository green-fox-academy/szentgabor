using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\AG\Green Fox Academy\szentgabor\csharp\2nd week\Wednesday\Logs\Logs\log.txt";
            Console.WriteLine(GetPostRatio(path).ToString());
            foreach (var item in IPReturner(path))
            {
            Console.WriteLine(item);
            }
            Console.ReadLine();
            // Read all data from 'log.txt'.
            // Each line represents a log message from a web server
            // Write a function that returns an array with the unique IP adresses.
            // Write a function that returns the GET / POST request ratio.  
        }
        public static double GetPostRatio(string file)
        {
            string[] data = File.ReadAllLines(file);
            double get = 0.0;
            double post = 0.0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].ToString().Contains("POST"))
                {
                    post++;
                }
                else
                {
                    get++;
                }
            }
            double ratio = get / post;
            return ratio;
        }
        public static string[] IPReturner(string file)
        {
            string[] data = File.ReadAllLines(file);
            // string line = string.Empty;

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = data[i].Substring(27, 11);
            }
            return data;
        }
    }
}
