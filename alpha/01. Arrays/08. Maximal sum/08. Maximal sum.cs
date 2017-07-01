using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Maximal_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, tempSum, maxSum = 0;
            int[] numbers;

            n = int.Parse(Console.ReadLine());
            numbers = new int[n];

            for (i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            tempSum = numbers[0];

            for (i = 1; i < n; i++)
            {
                if (numbers[i - 1] < numbers[i])
                    tempSum += numbers[i];
                else
                    if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                    tempSum = numbers[i - 1];
                }
                if (tempSum > maxSum)
                    maxSum = tempSum;
            }

            Console.WriteLine(maxSum);
        }
    }
}
