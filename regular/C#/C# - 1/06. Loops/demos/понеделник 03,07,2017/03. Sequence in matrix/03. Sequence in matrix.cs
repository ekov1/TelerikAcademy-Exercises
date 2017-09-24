using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sequence_in_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] numbers;
            int n, m, i, j, seq = 0, bestSeq = 0;

            input = Console.ReadLine(); // n m
            numbers = input.Split(' ');

            n = int.Parse(numbers[0]);
            m = int.Parse(numbers[1]);

            int[,] matrix = new int[n, m];
            int[] row;

            matrix = new int[n, m];
            if (n > m)
                row = new int[n];
            else
                row = new int[m];

            for (i = 0; i < n; i++)
            {
                input = Console.ReadLine(); // numbers for matix row i
                numbers = input.Split(' ');

                for (j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(numbers[j]);
                }
            }

            // check

            // bestSeq = CheckCols(matrix, seq, bestSeq);
            // bestSeq = CheckRows(matrix, seq, bestSeq);
            bestSeq = CheckDiagonals(matrix, row, seq, bestSeq);

            Console.WriteLine(bestSeq);
        }

        private static int CheckDiagonals(int[,] matrix, int[] row, int seq, int bestSeq)
        {
            int low, high, i, j;
            // check diagonals left to right -> \\\\\ left upper to right down
            if (matrix.GetLength(0) > matrix.GetLength(1))
            {
                high = matrix.GetLength(0); // rows
                low = matrix.GetLength(1); // cols

                for (i = 0; i < high; i++)
                {
                    for (j = 0; j < low; j++)
                    {
                        row[j] = matrix[high - 1 - i + j, j];
                    }

                    seq = CheckSeq(row, j);
                    bestSeq = Math.Max(seq, bestSeq);
                }
            }
            else
            {
                high = matrix.GetLength(1); // cols
                low = matrix.GetLength(0); // rows
            }

            return bestSeq;
        }

        private static int CheckSeq(int[] row, int j)
        {
            int counter = 1, max = 0;

            for (int i = 0; i < j - 1; i++)
            {
                if (row[i] == row[i + 1])
                    counter++;
                else
                    counter = 1;

                max = Math.Max(counter, max);
            }

            return counter;
        }

        private static int CheckCols(int[,] matrix, int seq, int bestSeq)
        {
            seq = 0;
            int num, i = 0, j = 0;

            for (j = 0; j < matrix.GetLength(1); j++)
            {
                i = 0;
                seq = 0;
                num = matrix[i, j];
                for (i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] == num)
                        seq++;
                    else
                    {
                        num = matrix[i, j];
                        seq = 1;
                    }

                    bestSeq = Math.Max(seq, bestSeq);
                    //Console.WriteLine(bestSeq);
                }
            }

            return bestSeq;
        }

        private static int CheckRows(int[,] matrix, int seq, int bestSeq)
        {
            seq = 0;
            int num, i = 0, j = 0;

            for (i = 0; i < matrix.GetLength(0); i++)
            {
                j = 0;
                seq = 0;
                num = matrix[i, j];

                for (j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == num)
                        seq++;
                    else
                    {
                        num = matrix[i, j];
                        seq = 1;
                    }

                    bestSeq = Math.Max(seq, bestSeq);
                    //Console.WriteLine(bestSeq);
                }
            }

            return bestSeq;
        }
    }
}
