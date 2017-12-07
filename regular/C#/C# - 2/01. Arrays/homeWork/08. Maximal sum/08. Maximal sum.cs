using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Maximal_sum
{
    class Program
    {
        /// <summary>
        /// Maximal sum
        /// 
        /// Description:
        /// Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.
        /// Can you do it with only one loop (with single scan through the elements of the array)?
        /// 
        /// Input:
        /// On the first line you will receive the number N
        /// On the next N lines the numbers of the array will be given
        /// 
        /// Output:
        /// Print the maximal sum of consecutive numbers
        /// 
        /// Constraints:
        //  1 <= N <= 1024
        //  Time limit: 0.1s
        //  Memory limit: 16MB
        /// </summary>

        //static void Main(string[] args)
        //{
        //    int n, answer;
        //    int[] numbers;

        //    n = int.Parse(Console.ReadLine());
        //    numbers = new int[n];

        //    // record array
        //    for (int i = 0; i < n; i++)
        //    {
        //        numbers[i] = int.Parse(Console.ReadLine());
        //    }

        //    answer = MaxSumTwoLops(numbers);
        //    Console.WriteLine(answer);
        //}

        //static int MaxSumTwoLops(int[] numbers)
        //{
        //    int tempSum;
        //    int answer = 0;
        //    int length = numbers.Length;

        //    for (int i = 0; i < length; i++)
        //    {
        //        tempSum = numbers[i];
        //        for (int j = i + 1; j < length; j++)
        //        {
        //            tempSum += numbers[j];
        //            if (tempSum > answer)
        //            {
        //                answer = tempSum;
        //            }
        //        }
        //    }

        //    return answer;
        //}
    }
}
