using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            //  var tq = n.Select(x => n.Where(t => t == x).Count());

            var zorba = n.Distinct().ToDictionary(x => x, x => n.Where(t => t == x).Count());
            foreach (KeyValuePair<int, int> item in zorba)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var quar = n.GroupBy(a => a);

            foreach (var item in quar)
            {
                Console.WriteLine($"{item.Key} {item.Count()}");
            }

            Console.WriteLine();

            var quaresma = from k in n
                           group k by k into kuala
                           select new { Key = kuala.Key, Count = kuala.Count() };

            foreach (var item in quaresma)
            {
                Console.WriteLine(item.Key + " " + item.Count);
            }

            Console.ReadLine();
        }
    }
}
