using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp94
{
    public class Program
    {
        static void Main(string[] args)
        {
            string word = "Habbantota";
            word = word.ToLower();
            foreach (KeyValuePair<char, int> pair in LetterCounter(word))
            {
                Console.WriteLine(pair);
            }
            Console.ReadLine();
        }

        public  Dictionary<char, int> LetterCounter(string input)
        {
            Dictionary<char, int> letter = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!letter.ContainsKey(input[i]))
                {
                    letter.Add(input[i], 1);
                }
                else
                {
                    letter[input[i]]++;
                }
            }
            return letter;
        }
    }
}
