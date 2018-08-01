using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Program
    {
        static void Main(string[] args)
        {
            Guitar guitarFirst = new Guitar("polimer",0,6,"black");
            Guitar guitarSecond = new Guitar("metal",6,2,"white");
            Guitar guitarThird = new Guitar("wooden",3,2,"pink");
            Console.WriteLine("My first guitar is " + guitarFirst.color
                + ", but the second is " + guitarSecond.material);
            Console.WriteLine(Guitar.numberOfGuitars);
            guitarSecond.Playing(guitarSecond.strings);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    class Guitar
    {
        public static int numberOfGuitars = 0;

        public string material;
        public int strings;
        public int button;
        public string color;

        public Guitar(string material, int strings, int button, string color)
        {
            this.material = material;
            this.strings = strings;
            this.button = button;
            this.color = color;
            numberOfGuitars++;
        }

        public Guitar(string color)
        {
            material = "glass";
            strings = 5;
            button = 4;
            this.color = color;
            numberOfGuitars = 2;
        }

        public void Playing(int strings)
        {
            Console.WriteLine("I'm playing " + strings + " strings on my guitar.");
        }
    }
}
