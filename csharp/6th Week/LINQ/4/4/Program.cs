using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            var b = n.Where(x => x * x > 20).Select(x => x);
            Console.WriteLine(String.Join(", ", b));

            var c = from a in b
                    where (a * a > 20)
                    select a;

            Console.WriteLine(String.Join(", ", c));
        }
    }
}
