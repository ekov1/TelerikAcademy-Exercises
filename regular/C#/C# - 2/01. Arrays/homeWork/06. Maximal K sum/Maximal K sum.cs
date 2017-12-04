using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Maximal K sum
/// 
/// Description:
/// Write a program that reads two integer numbers N and
/// K and an array of N elements from the console.
/// Find the maximal sum of K elements in the array.
/// 
/// Input:
/// On the first line you will receive the number N
/// On the second line you will receive the number K
/// On the next N lines the numbers of the array will be given
///
/// Output:
/// Print the maximal sum of K elements in the array
/// 
/// Constraints:
/// 
//  1 <= N <= 1024
//  1 <= K <= N
//  Time limit: 0.1s
//  Memory limit: 16MB
/// 
/// </summary>

namespace _06.Maximal_K_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k,
                answer = 0;
            int[] numbers;

            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Console.WriteLine("numbers[0] = " + numbers[0]);
            Array.Sort(numbers);
            // Console.WriteLine("numbers[0] = " + numbers[0]);
            numbers = numbers.Reverse().ToArray();
            // Console.WriteLine("numbers[0] = " + numbers[0]);
            for (int i = 0; i < k; i++)
            {
                answer += numbers[i];
                //Console.WriteLine(answer);
                //Console.WriteLine(numbers[i]);
            }

            // Console.WriteLine();
            Console.WriteLine(answer);
        }
    }
}
