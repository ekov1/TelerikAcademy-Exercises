using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Maximal_sum
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

            // PrintMatrix(matrix, n, m);

            for (i = 0; i < n - 2; i++)
            {
                for (j = 0; j < m - 2; j++)
                {
                    row = i;
                    col = j;
                    sum = Calculate3x3(matrix, row, col);
                    bestSum = Math.Max(sum, bestSum);
                }
            }

            Console.WriteLine(bestSum);
        }

        private static int Calculate3x3(int[,] matrix, int row, int col)
        {
            int i, j, sum = 0;

            for (i = row; i < row + 3; i++)
            {
                for (j = col; j < col + 3; j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }

        private static void PrintMatrix(int[,] matrix, int n, int m)
        {

            //принт
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j == m - 1)
                        Console.Write(matrix[i, j]);
                    else
                        Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
