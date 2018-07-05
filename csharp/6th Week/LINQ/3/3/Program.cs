using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var kl = from s in n
                     where (s > 0)
                     select s * s;

            Console.WriteLine(String.Join(", ", kl));

            Console.WriteLine();

            var pl = n.Where(x => x > 0).Select(x => x * x);
            Console.WriteLine(String.Join(", ", pl));

            Console.WriteLine();

        }
    }
}
