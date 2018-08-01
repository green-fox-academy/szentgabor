using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 3;
            a += 10;
            // make it bigger by 10

            Console.WriteLine(a);

            int b = 100;
            b -= 7;
            // make it smaller by 7

            Console.WriteLine(b);

            int c = 44;
            // please double c's value
            c *= 2;

            Console.WriteLine(c);

            int d = 125;
            // please divide by 5 d's value
            d /= 5;

            Console.WriteLine(d);

            int e = 8;
            // please cube of e's value
            e *= e;
            Console.WriteLine(e);

            int f1 = 123;
            int f2 = 345;
            bool biggerf1 = true;
            bool notbiggerf1 = false;
            if (f1 > f2) {
                Console.WriteLine("{0} f1 is bigger than f2: ",biggerf1);
            }
            else {
                Console.WriteLine("{1} f1 is bigger than f2: ",notbiggerf1);
            }
            // tell if f1 is bigger than f2 (print as a boolean)

            int g1 = 350;
            int g2 = 200;
            bool g2big = true;
            // tell if the double of g2 is bigger than g1 (print as a boolean)
            if (g1 < g2 * 2)
            {
                Console.WriteLine("{0} The double of g2 is larger than g1: ",g2big);
            }

            long h = 1357988018575474;
            bool remainder = h % 11 == 0;
            if (h % 11 == 0)
                           {
                Console.WriteLine(remainder);
            }
            // tell if it has 11 as a divisor (print as a boolean)

            int i1 = 10;
            int i2 = 3;

            if (i2^3 > i1 && i1 > i2^2)
            {
                Console.WriteLine(bool)
            }
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)

            int j = 1521;
            // tell if j is dividable by 3 or 5 (print as a boolean)

            if (j % 3 == 0 || j % 5 == 0)
            {
                Console.WriteLine("true");
            }
            {
                Console.WriteLine("false");
            }
            string k = "Apple";
            //fill the k variable with its cotnent 4 times
            for (int i = 0; i < 4; i++)
            {
                Console.Write(k);
            }
            
        }
    }
}