using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp61
{
    class Program
    {
        static void Main(string[] args)
        {
            Human james = new Human("James", 3978);
            Console.WriteLine(james.GetName());
            james.SetName("Paul");
            Console.WriteLine(james.GetName());
            Console.ReadLine();
        }
    }
}
