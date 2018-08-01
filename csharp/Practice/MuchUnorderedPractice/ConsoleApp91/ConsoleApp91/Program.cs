using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp91
{
    class Program
    {
        static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            OrderedDominoes(dominoes);
            Console.ReadLine();
        }
        public static List<Domino> InitializeDominoes()
        {
            List<Domino> dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }
        public static void OrderedDominoes(List<Domino> dominoes)
        {
            List<int[]> output = new List<int[]>();

            for (int i = 0; i < dominoes.Count; i++)
            {
                for (int j = 0; j < dominoes.Count; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        output.Add(dominoes[i].GetValues());
                    }
                    else if (output[i][1] == dominoes[j].GetValues()[0])
                    {
                        output.Add(dominoes[j].GetValues());
                    }
                }
            }
            foreach (var item in output)
            {
                Console.Write("[");
                for (int i = 0; i < item.Length; i++)
                {
                    Console.Write(item[i]);
                    if (i == 0)
                    {
                        Console.Write(", ");
                    }
                }
                Console.Write("]");
            }
        }
    }
}
