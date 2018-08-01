using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            string yoloText = "YOLO";
            yoloText = yoloText.Replace('O', "YOLO");
            Console.WriteLine(yoloText);
            string stg2;
            Console.WriteLine(yoloText.Length);
            Console.WriteLine(yoloText.ToUpper().Contains("Y") );

            Console.WriteLine(yoloText.split);

            foreach (var word in yoloText.Split("L"))
            {
                Console.WriteLine(word);
            }
            Console.WriteLine(yoloText.Substring(0, 1));
            Console.ReadLine();
            }
    }
}
