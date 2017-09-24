using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string choice = Console.ReadLine();
            int[,] matrix = new int[n, n];

            switch (choice)
            {
                case "a":
                    FillMatrixA(matrix, n);
                    break;
                case "b":
                    FillMatrixB(matrix, n);
                    break;
                case "c":
                    FillMatrixC(matrix, n);
                    break;
                case "d":
                    FillMatrixD(matrix, n);
                    break;
            }

            PrintMatrix(matrix);
        }

        public static void FillMatrixA(int[,] matrix, int n)
        {
            int currentValue = 1;
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = currentValue++;
                }
            }
        }

        public static void FillMatrixB(int[,] matrix, int n)
        {
            int currentValue = 1;
            for (int col = 0; col < n; col++)
            {
                bool isEvenCol = col % 2 == 0;
                if (isEvenCol)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = currentValue++;
                    }
                }
                else
                {
                    for (int row = n - 1; row > -1; row--)
                    {
                        matrix[row, col] = currentValue++;
                    }
                }
            }
        }

        public static void FillMatrixC(int[,] matrix, int n)
        {
            int currentValue = 1;
            int currentX = n - 1;
            int currentY = 0;
            while (currentValue <= n * n)
            {
                currentValue = FillDiagonal(matrix, n, currentX, currentY, currentValue);

                if (currentX == 0)
                {
                    currentY++;
                }
                else
                {
                    currentX--;
                }
            }
        }

        public static int FillDiagonal(int[,] matrix, int n, int currentX, int currentY, int currentValue)
        {
            while (currentX < n && currentY < n)
            {
                matrix[currentX++, currentY++] = currentValue++;
            }

            return currentValue;
        }

        public static void FillMatrixD(int[,] matrix, int n)
        {
            int currentValue = 1;
            int currentX = 0;
            int currentY = 0;
            int xInc = 1;
            int yInc = 0;

            while (currentValue <= n * n)
            {
                if (currentX == n || currentX == -1 || currentY == n || currentY == -1 || matrix[currentX, currentY] != 0)
                {
                    if (xInc == 1)
                    {
                        currentX--;
                        xInc = 0;
                        yInc = 1;
                        currentY += yInc;
                    }
                    else if (xInc == -1)
                    {
                        currentX++;
                        xInc = 0;
                        yInc = -1;
                        currentY += yInc;
                    }
                    else if (yInc == 1)
                    {
                        currentY--;
                        yInc = 0;
                        xInc = -1;
                        currentX += xInc;
                    }
                    else if (yInc == -1)
                    {
                        currentY++;
                        yInc = 0;
                        xInc = 1;
                        currentX += xInc;
                    }
                }

                matrix[currentX, currentY] = currentValue++;
                currentX += xInc;
                currentY += yInc;
            }
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0}", matrix[row, col]);
                    if (col < matrix.GetLength(1) - 1)
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}