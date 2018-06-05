using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwearFriendlizer
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\AG\Green Fox Academy\szentgabor\csharp\SwearFriendlizer\SwearFriendlizer\RightWords.txt";
            var offensiveWords = new List<string>() { "fuck", "bloody", "cock", "shit", "fucker", "fuckstick", "asshole", "dick", "piss" };
            Console.WriteLine(FamilyFriendlizer(path, offensiveWords)); // should print out 17
            Console.ReadLine();
        }
        private static int FamilyFriendlizer(string path, List<string> offensiveWords)
        {
            string[] stuff = File.ReadAllLines(path);
            int notNiceWords = 0;
            for (int j = 0; j < stuff.Length; j++)
            {
                for (int i = 0; i < offensiveWords.Count; i++)
                {
                    stuff[i] = stuff[i].ToLower();
                    if (stuff[i].Contains(offensiveWords[j]))
                        notNiceWords++;
                }
            }
        return notNiceWords;
        }
                
        }
    }

//stuff.Contains("fuck");

//int notNiceWords = 0;

//for (int i = 0; i < offensiveWords.Count; i++)
//{
//    if (stuff.Contains(offensiveWords[i]))
//    {
//        notNiceWords++;
//    }
//}
//return notNiceWords;