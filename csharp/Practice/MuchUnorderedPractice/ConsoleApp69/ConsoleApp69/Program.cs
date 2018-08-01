using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp69
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `animals`
            //   with the following content: `["kuty", "macsk", "cic"]`
            // - Add all elements an `"a"` at the end
            string[] animals = { "kuty", "macsk", "cic" };
            AAdder(animals);
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
            }

        }
        public static string[] AAdder(string[] animals)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] += 'a';
            }
            return animals;
        }
    }
}
