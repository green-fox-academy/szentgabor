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

            Console.WriteLine(yoloText.Split());

            foreach (var word in yoloText.Split("L"))
            {
                Console.WriteLine(word);
            }
            Console.WriteLine(yoloText.Substring(0, 1));
            StringBuilder sentenceBuilder = new StringBuilder();
            sentenceBuilder
                .Append("YOLOkA")
                .Append(" ")
                .Append("swag");
            Console.WriteLine(sentenceBuilder);

            List<int> numbersOfTheDays = new List<int>;

            numbersOfTheDays.Add(7);
            numbersOfTheDays.Add(8);
            numbersOfTheDays.Add(9);
            numbersOfTheDays.Add(10);
            numbersOfTheDays.Insert(4, 5);


            Console.WriteLine(numbersOfTheDays.Count);

            number

            public string AllThe numbers(List<int> inputNumbers)
        {
            StringBuilder numberBuilder = new StringBuilder { };
            //itt van egy foreach, azt megnézni és megérteni!
        }

        Dictionary<Char, Int32> letterCounter = new Dictionary<char, int>();

        string WordtoCountLetters = "YOLO SWAG afdajlsfdlagju";

        letterCounter.Add('A', 3)
        letterCounter.Add['A'] = 2);

            foreach (KeyValuePair<Char, Int32> entry in letterCounter)
            {
            Console.WriteLine(entry.key + ":" + entry.Value);
            }

            Console.ReadLine();
            }
    }
}
