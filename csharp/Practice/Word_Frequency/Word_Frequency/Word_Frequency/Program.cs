using System;
using System.Collections.Generic;
using System.IO;

namespace Word_Frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"C:\AG\Green Fox Academy\Foundation Exam Retake\fulvipes-basic-exam-retake\Word_Frequency\Word_Frequency\Word_Frequency\input.txt";
            string output = @"C:\AG\Green Fox Academy\Foundation Exam Retake\fulvipes-basic-exam-retake\Word_Frequency\Word_Frequency\Word_Frequency\output.txt";
            int frequency = 2;
            File2Writer(output, WordFrequency(input, frequency));
            Console.ReadLine();
        }

        public static List<string> WordFrequency(string file, int freq)
        {
                List<string> words = new List<string>();
            try
            {
                StreamReader sr = new StreamReader(file);

                int counter = 0;
                string[] fields = null;
                string line = null;
                List<string> temp = new List<string> { };

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    fields = line.Split(' ');
                    for (int i = 0; i < fields.Length; i++)
                    {
                        Console.WriteLine(fields[i]);
                        temp.Add(fields[i]);
                    }
                    counter += fields.Length;
                }
                sr.Close();
                
                Console.WriteLine(counter);

                Dictionary<string, Int32> wordFrequency = new Dictionary<string, Int32>();
                foreach (var item in temp)
                {
                    if (!wordFrequency.ContainsKey(item))
                    {
                        wordFrequency.Add(item, 1);
                    }
                    else
                    {
                        wordFrequency[item] ++;
                    }
                }

                Console.Write("The words appearing {0} times are: ", freq);
                foreach (KeyValuePair<string, Int32> pair in wordFrequency)
                {
                    if (pair.Value == freq)
                    {
                    Console.Write("{0}, ", pair.Key);
                    words.Add(pair.Key);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return words;
        }
        public static void File2Writer(string file2, List<string> list)
        {
            {
                File.WriteAllLines(file2, list);
            }
        }
    }
}
