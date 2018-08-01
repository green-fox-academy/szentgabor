using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp89
{
    class Program
    {
        static void Main(string[] args)
        {
            PostIt postItOne = new PostIt("orange", "GREAT", "purple");
            PostIt postItTwo = new PostIt("yellow", "SUPERB", "green");
            PostIt postItThree = new PostIt("pink", "HALL", "blueish");

            Console.WriteLine(postItOne.PostItShower());
            postItTwo.PostItShower();
            postItThree.PostItShower();
            Console.WriteLine(postItOne.text);

            Console.ReadLine();
        }
    }

    struct PostIt
    {
        string backGroundColor;
        public string text;
        string textColor;

        public PostIt(string backGroundColor, string text, string textColor)
        {
            this.backGroundColor = backGroundColor;
            this.text = text;
            this.textColor = textColor;
        }

        public string PostItShower()
        {
            string output = string.Format("Background color is {0}, the text is \"{1}\" and the textcolor is {2}.", backGroundColor, text, textColor);
            return output;
        }
    }
}
