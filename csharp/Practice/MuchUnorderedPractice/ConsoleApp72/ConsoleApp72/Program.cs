using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp72
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that
            // - takes a filename as a parameter,
            // - reads a csv file which rows contains data in the following format: <person name>;<birthdate in YYYY-MM-DD format>;<city name>
            // - returns the year when the most births happend.

            // You can find such a csv file in this directory: births.csv
            // If you pass births.csv to your function, the result should be 2006.
        }
        string file = @"TextFile.txt";
        public static int YearReturner(string file)
        {
            Dictionary<string, DateTime> dict = new Dictionary<string, DateTime>();

        }
    }
}
