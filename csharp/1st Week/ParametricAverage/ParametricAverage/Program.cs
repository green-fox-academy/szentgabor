using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametricAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter five integers!");
            double sum = 0;
            double average = 0;
            double[] answer = new double[5];
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = Int32.Parse(Console.ReadLine());
                sum += answer[i];
            }
            average = sum / answer.Length;
            Console.WriteLine("Sum = {0} Average = {1}", sum, average);
            Console.ReadLine();
        }
    }
}
