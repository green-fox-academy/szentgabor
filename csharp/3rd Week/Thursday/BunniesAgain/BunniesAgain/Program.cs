using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunniesAgain
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine(BunnyEarCounter(10));
                Console.ReadLine();
            }
            public static int BunnyEarCounter(int n)
            {
                if (n == 0)
                {
                    return 0;
                }
                else if (n % 2 == 1)
                {
                    return BunnyEarCounter(n - 1) + 2;
                }
                else
                {
                    return BunnyEarCounter(n - 1) + 3;
                }
            }
        }
    }
