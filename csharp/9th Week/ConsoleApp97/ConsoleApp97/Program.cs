using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp97
{
    class Program
    {
        static void Main(string[] args)
        {
            string matrix = "1 2 3\n12 13 14\n23 24 25";

            foreach (var item in MatrixIncrease(MatrixChecker(matrix)))
            {
            Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static List<string> MatrixChecker(string matrixArray)
        {
            string[] matrixRows = matrixArray.Split(
                                  new[] { "\r\n", "\r", "\n" },
                                  StringSplitOptions.None);

            List<string> rowNumbers = new List<string>();
            foreach (string row in matrixRows)
            {
                string[] nums = row.Split(new[] { " " }, StringSplitOptions.None);

                foreach (var item in nums)
                {
                    rowNumbers.Add(item);
                }
            }
            if (matrixRows.Length != rowNumbers.Count / matrixRows.Length)
            {
                throw new Exception();
            }
            return rowNumbers;
        }

        public static int[] MatrixIncrease(List<string> matrix)
        {
            int[] myInts = matrix.Select(int.Parse).ToArray();
//            Convert.ToDouble(myInts);
            double squareRoot = Math.Sqrt(myInts.Length);
            int sqRoot = (int)squareRoot;

            int counter = 0;
            int counter1 = 0;

            for (int i = 0; i < myInts.Length - squareRoot; i++)
            {
                if (myInts[i] < myInts[i + sqRoot])
                {
                    counter++;
                }
            }

            for (int j = 0; j < myInts.Length - 1; j++)
            {
                if (j == 0 && myInts[j] < myInts[j + 1])
                {
                    counter1++;
                }

                else if ((j + 1) % sqRoot != 0 && myInts[j] < myInts[j + 1])
                {
                    counter1++;
                }
            }

            if (counter == counter1)
            {
                return myInts;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}