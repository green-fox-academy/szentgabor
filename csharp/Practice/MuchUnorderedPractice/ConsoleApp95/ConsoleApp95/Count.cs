using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp95
{
    public class Count
    {
        public Dictionary<char, int> LetterCounter(string input)
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
