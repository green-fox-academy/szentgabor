using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[][]{
                new int[]{ 1, 2, 3},
                new int[]{ 4, 5, 6},
                new int[]{ 7, 8, 9}
            };

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                Console.WriteLine($"{i} : {j} = {matrix[i][j]}");
                }
            }
        }

        public bool IsSymmetric(int[][] matrix)
        {

        }
    }
}
