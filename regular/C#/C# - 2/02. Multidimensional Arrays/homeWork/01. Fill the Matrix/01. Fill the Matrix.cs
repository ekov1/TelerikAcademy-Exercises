using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fill_the_Matrix
{
    class Program
    {
        static int n;
        static int[,] matrix;
        static int counter = 1;

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            matrix = new int[n, n];
            string letter = Console.ReadLine().ToLower();



            switch (letter)
            {
                case "a":
                    FillMatrixA();
                    break;

                case "b":
                    FillMatrixB();
                    break;

                case "c":
                    FillMatrixC();
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
                    if (j != matrix.GetLength(1))
                    {
                        if (i < 10)
                        {
                            Console.Write("{0,2} ", matrix[i, j]);
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
                    matrix[j, i] = counter++;
                }
            }
        }

        private static void FillMatrixB()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {

                        matrix[j, i] = counter++;
                    }
                }
                else
                {
                    for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                    {

                        matrix[j, i] = counter++;
                    }
                }

            }
        }
        // end b

        private static void FillMatrixC()
        {
            // for (int i = matrix.GetLength(0)-1; i < matrix.GetLength(0); i++)
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    matrix[n - 1 - i+j, j] = counter++;
                }
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n-i; j++)
                {
                    matrix[j, i + j] = counter++;
                }
            }

        }

        // 789
        // 456
        // 123
        //            for (int i = 0; i<n; i++)
        //            {
        //                for (int j = 0; j<n; j++)
        //                {
        //                    matrix[n - 1 - i, j] = counter++;
        //                }
        //}

        // 456
        // 023
        // 001
        //        for (int i = 0; i<n; i++)
        //            {
        //                for (int j = n-1-i; j<n; j++)
        //                {
        //                    matrix[n - 1 - i, j] = counter++;
        //                }
        //}
    }
}
