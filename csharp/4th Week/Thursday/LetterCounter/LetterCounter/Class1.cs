using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCounter
{
    public static class Class1
    {
        public static void StringToDictionary(string word)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (dict.ContainsKey(word[i]))
                {
                    dict[word[i]]++;
                }
                else
                {
                    dict.Add(word[i], 1);
                }
            }

                foreach (KeyValuePair<Char, int> kl in dict)
                {
                    //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                    Console.WriteLine(string.Format("Key = {0}, Value = {1}", kl.Key, kl.Value));
                }
        }
    }
}