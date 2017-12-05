using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Selection_sort
{
    class Program
    {
        /// <summary>
        /// Selection sort
        /// 
        /// Description:
        /// Sorting an array means to arrange its elements in increasing order.
        /// Write a program to sort an array. Use the Selection sort algorithm: 
        /// Find the smallest element, move it at the first position,
        /// find the smallest from the rest, move it at the second position, etc.
        /// 
        /// Input:
        /// On the first line you will receive the number N
        /// On the next N lines the numbers of the array will be given
        /// 
        /// Output:
        /// Print the sorted array
        /// Each number should be on a new line
        /// 
        /// Constraints:
        //  1 <= N <= 1024
        //  Time limit: 0.1s
        //  Memory limit: 16MB
        /// </summary>

        static void Main(string[] args)
        {
            int n;
            int[] numbers;

            n = int.Parse(Console.ReadLine());
            numbers = new int[n];

            // record array
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            SelectionSort(numbers);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        static void SelectionSort(int[] numbers)
        {
            int temp;
            int length = numbers.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
        }
    }
}
