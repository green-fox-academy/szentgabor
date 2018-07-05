using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var kl = (from s in n
                      where s % 2 != 0
                      select s)
                     .Average();

            Console.WriteLine(kl);

            int average = n.Sum() / n.Length;

            var dl = n.Where(x => x % 2 != 0).Average(x => x.ToString().Length);
            Console.WriteLine(dl);

            var ml = n.Where(x => x % 2 != 0).Average(x => x);
            Console.WriteLine(ml);

            var bl = n.Average();
            Console.WriteLine(bl);
        }
    }
}
