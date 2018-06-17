using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortThatList_Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a list of numbers as parameter
            //  Returns a list where the elements are sorted in ascending numerical order
            //  Make a second boolean parameter, if it's `True` sort that list descending

            int[] sortExample = ListSorter(new int[] { 34, 12, 24, 9, 5 });

            for (int i = 0; i < sortExample.Length; i++)
            {
                Console.Write(sortExample[i] + " ");
            }
            // Console.WriteLine(AdvancedBubble(new int[] { 34, 12, 24, 9, 5 }, true));
            //  should print [34, 24, 12, 9, 5]
            Console.ReadLine();
        }
        public static int[] ListSorter(int[] sort)
            {
            int storer = 0;
            for (int i = 0; i < sort.Length; i++)
            {
                for (int j = 0; j < sort.Length - 1; j++)
                {
                    if (sort[j] > sort[j + 1])
                    {
                        storer = sort[j];
                        sort[j] = sort[j + 1];
                        sort[j + 1] = storer;
                    }
                }
            }
            return sort;
        }
    }
}
