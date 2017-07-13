using System;

namespace _06.Maximal_K_sum
{
    class Program
    {
        static void Main()
        {
            int n,k, i, maxKSum=0;
            int[] numbers;

            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            numbers = new int[n];

            for (i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Array.Sort(numbers);
            // Array.Reverse(numbers);

            BubbleSort(numbers);

            for (i = 0; i < k; i++)
                maxKSum += numbers[i];

            Console.WriteLine(maxKSum);
        }

        private static void BubbleSort(int[] numbers)
        {
            int i, j,temp;

            for (i = numbers.Length - 1; i >= 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
        }
    }
}
