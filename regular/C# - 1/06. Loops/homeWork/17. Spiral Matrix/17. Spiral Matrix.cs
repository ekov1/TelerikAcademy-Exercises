using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Spiral_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[,] matrix;

            n = int.Parse(Console.ReadLine());
            matrix = new int[n, n];

            FillSpiral(matrix, n);

            PrintMatrix(matrix);

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

        public static void FillSpiral(int[,] matrix, int n)
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
    }
}
