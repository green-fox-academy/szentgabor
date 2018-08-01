using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp62
{
    class Program
    {
        static void Main(string[] args)
        {
            int given = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Factorio(given));
            Console.ReadLine();
        }
        public static int Factorio(int toBeFactored)
        {
            int a = 1;
            for (int i = 1; i < toBeFactored + 1; i++)
            {
                a *= i;
            }
            return a;
        }
    }
}
