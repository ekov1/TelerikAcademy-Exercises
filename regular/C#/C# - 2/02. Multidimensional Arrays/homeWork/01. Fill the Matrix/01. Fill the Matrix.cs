using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fill_the_Matrix
{
    class Program
    {
        static int[,] matrix;
        static int counter = 0;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            matrix = new int[n, n];
            string letter = Console.ReadLine().ToLower();



            switch (letter)
            {
                case "a":
                    FillMatrixA();
                    break;

            }

            PrintMatrix();

        }

        // Methods
        private static void PrintMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j!=4)
                    {
                        if (i<10)
                        {
                            Console.Write(matrix[i, j] + "  ");
                        }
                        else
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        
                    }
                    else
                    {
                        Console.Write(matrix[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrixA()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = counter++;
                }
            }
        }
    }
}
