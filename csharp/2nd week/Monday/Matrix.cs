using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 4;
            int heigth = 4;

            int[,] matrixArray = new int[width, heigth];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < heigth; j++)
                {
                    if (i == j)
                    {
                        Console.Write(1 + " ");
                    }
                    else
                    {
                        Console.Write(matrixArray[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output
            Console.ReadLine();
        }
    }
}