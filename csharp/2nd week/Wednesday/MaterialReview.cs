using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstSolution();
            Console.WriteLine("Give me one word:");
            string userInput = Console.ReadLine();
            writeSolutionOne(userInput);
            SecondSolution();
            Console.ReadLine();
        }
        public static void FirstSolution()
        {
            string data = "";
            StreamReader sr = new StreamReader("file.txt");
            while (data != null)
            {
                data = sr.ReadLine();
                if (data != null)
                {
                    Console.WriteLine(data);
                }

            }
            sr.Dispose();
            // ezzel bezárunk minden kapcsolatot elenged, lezártnak tekinti

            Console.ReadLine();
            // string data = sw.ReadLine();
            // Console.WriteLine(data);
            // Console.ReadLine();
        }
        public static void SecondSolution()
        {
            Console.WriteLine(File.ReadAllText("file.txt"));

            //a streamreaderrel körülményesebb, de jobban bele tudunk nyúlni a működésébe
        }
        {
        public static void ThridSolution()

            File.WriteAllText("file.txt", something)
        }
    }
}
