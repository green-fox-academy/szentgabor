using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp78
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(IsThereSeven(List));
        }
        public static string IsThereSeven(List<int> list)
        {
            bool right = false;
            string good = "Hoooray!";
            string no = "Nooooo!";

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 7)
                {
                    right = true;
                }
            }
            if (right)
            {
                return good;
            }
            else
            {
                return no;
            }
        }
    }
}
