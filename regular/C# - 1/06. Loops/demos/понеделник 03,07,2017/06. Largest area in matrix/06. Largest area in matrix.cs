using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Largest_area_in_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] numbers;
            int n, m, i, j, row = 0, col = 0, sum = 0, bestSum = int.MinValue;

            input = Console.ReadLine(); // n m
            numbers = input.Split(' ');

            n = int.Parse(numbers[0]);
            m = int.Parse(numbers[1]);

            int[,] matrix = new int[n, m];

            for (i = 0; i < n; i++)
            {
                input = Console.ReadLine(); // numbers for matix row i
                numbers = input.Split(' ');

                for (j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(numbers[j]);
                }
            }
        }
    }
}
