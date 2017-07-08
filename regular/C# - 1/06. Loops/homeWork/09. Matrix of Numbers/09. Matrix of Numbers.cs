using System;

namespace _09.Matrix_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[,] matrix;

            n = int.Parse(Console.ReadLine());
            matrix = new int[n, n];

            FillMatrix(matrix);

            PrintMatrix(matrix);
        }

        private static void FillMatrix(int[,] matrix)
        {
            int i, j, cols, rows, basis = 1, counter;

            rows = matrix.GetLength(0);
            cols = matrix.GetLength(1);

            for (i = 0; i < rows; i++)
            {
                counter = basis;
                for (j = 0; j < cols; j++)
                {
                    matrix[i, j] = counter;
                    counter++;
                }
                basis++;
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            int i, j, cols, rows;

            rows = matrix.GetLength(0);
            cols = matrix.GetLength(1);

            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
