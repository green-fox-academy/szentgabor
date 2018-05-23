using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    class Program
    {
        static void Main(string[] args)
        {
            PostIt myFirstObject = new PostIt("orange", "Idea 1", "blue");
            PostIt mySecondObject = new PostIt("pink", "Awesome", "black");
            PostIt myThirdObject = new PostIt("yellow", "Superb", "green");

            Console.WriteLine(myFirstObject.backGroundColor);
            Console.ReadKey();
        }
        public struct PostIt
        {
            public string backGroundColor;
            public string someText;
            public string textColor;

            public PostIt(string backGroundColor, string someText, string textColor)
            {
                this.backGroundColor = backGroundColor;
                this.someText = someText;
                this.textColor = textColor;
            }
        }
    }
}
