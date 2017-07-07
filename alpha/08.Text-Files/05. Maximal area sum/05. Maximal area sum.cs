using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Maximal_area_sum
{
    //# Maximal area sum

    //## Description
    //    Write a program that reads a text file containing a square matrix of numbers.
    //    Find an area of size `2 x 2` in the matrix, with a maximal sum of its elements.
    //      - The first line in the input file contains the size of matrix `N`.
    //  - Each of the next `N` lines contain `N` numbers separated by space.
    //  - The output should be a single number in a separate text file.

    //    _Example:_

    //| input | output |
    //|-------|--------|
    //| 4 <br> 2 3 3 4 <br> 0 2 3 4 <br> 3 7 1 2 <br> 4 3 3 2 | 17 |


    class Program
    {
        static void Main(string[] args)
        {

            string inputFileName = @"..\..\matrix.txt";
            string line;

            string[] numbers;
            int[,] matrix;
            int rows = 0, cols = 0, counter = 0;
            int m, n, i, j, row, col, sum = 0, bestSum = int.MinValue;

            StreamReader readerOne = new StreamReader(inputFileName);

            using (readerOne)
            {
                line = readerOne.ReadLine();
                numbers = line.Split(' ').ToArray();

                while (line != null)
                {
                    counter++;
                    line = readerOne.ReadLine();
                }
                //Console.WriteLine(counter);
                rows = counter;
                cols = numbers.Length;

                numbers = new string[counter];
                matrix = new int[rows, cols];
            }
            // PrintMatrix(matrix);
            readerOne = new StreamReader(inputFileName);

            int br = 0;

            using (readerOne)
            {
                for ( i = 0; i < counter; i++)
                {
                    line = readerOne.ReadLine();
                    numbers = line.Split(' ').ToArray();

                    for ( j = 0; j < numbers.Length; j++)
                    {
                        br++;
                        //Console.WriteLine(br);
                        matrix[i, j] = 0;
                        matrix[i, j] = int.Parse(numbers[j]);
                    }
                }
            }

            // PrintMatrix(matrix);

            
            n = matrix.GetLength(0);
            m = matrix.GetLength(1);

            for (i = 0; i < n - 2; i++)
            {
                for (j = 0; j < m - 2; j++)
                {
                    row = i;
                    //Console.WriteLine("row = " + row);
                    col = j;
                    //Console.WriteLine("col = " + col);
                    sum = Calculate2x2(matrix, row, col);
                    //Console.WriteLine("sum = " + sum);
                    //if (i == 0 && j == 0) bestSum = sum;
                    bestSum = Math.Max(sum, bestSum);
                    //Console.WriteLine("bestSum = " + bestSum);
                }
            }

            Console.WriteLine(bestSum);

        }

        private static void PrintMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

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

        private static int Calculate2x2(int[,] matrix, int row, int col)
        {
            int i, j, sum = 0;

            for (i = row; i < row + 2; i++)
            {
                for (j = col; j < col + 2; j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }

    }
}
