using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add an integer to help me draw a tringili triangle!");
            int a = Int32.Parse(Console.ReadLine());
            string temp = "";

            for (int i = 0; i < a; i++)
            {
                temp += "*";
                Console.WriteLine(temp);

            }
            Console.ReadLine();
        }
    }
}

