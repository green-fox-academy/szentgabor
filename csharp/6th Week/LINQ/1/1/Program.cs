using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var number = from kld in n
                         where kld % 2 == 0
            //           orderby kl
                         select kld;

            foreach (var item in number)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            int[] s = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var numbers = from kld in s
                         where kld % 2 == 0
                         orderby kld
                         select kld;

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var kl = n.Where(z => (z % 2 == 0)).OrderBy(z => z.ToString().Length);
            foreach (var item in kl)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var dl = n.Where(z => (z % 2 == 0)).OrderBy(z => z);

            Console.WriteLine(String.Join(", ", dl));

            foreach (var item in dl)
            {
                Console.Write($"{item}, ");
            }
        }
    }
}
