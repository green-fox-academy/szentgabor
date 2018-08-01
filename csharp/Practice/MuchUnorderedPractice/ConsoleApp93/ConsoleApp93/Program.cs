using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp93
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool IsAnagram(string text1, string text2)
        {
            string word = null;
            if (text1.Length == text2.Length)
            {
                for (int i = 0; i < text1.Length; i++)
                {
                int counter = 0;
                    for (int j = 0; j < text2.Length; j++)
                    {
                        if (text1[i] == text2[j] && counter == 0)
                        {
                            word += text1[i];
                            counter++;
                        }
                    }
                }
            }
                return word.Length == text1.Length;
        }
    }
}
