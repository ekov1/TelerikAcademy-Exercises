using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PascalTriangle
{
    class PascalTriangle
    {
        private static int height;
        private static long[][] triangle;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Height");
            height = int.Parse(Console.ReadLine());

            // Alocate the array in the triangle form
            triangle = new long[height + 1][];

            for (int row = 0; row <= height; row++)
            {
                triangle[row] = new long[row + 1];
            }

            // Calculate the triangle
            triangle[0][0] = 1;

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }

            // Print the Triangle
            for (int row = 0; row <= height; row++)
            {
                Console.Write("".PadLeft((height - row) * 2));
                for (int col = 0; col < row; col++)
                {
                    Console.Write("{0,3} ", triangle[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
