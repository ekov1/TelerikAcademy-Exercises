using System;

namespace _07.Selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            int[] numbers;

            n = int.Parse(Console.ReadLine());
            numbers = new int[n];

            for (i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Selection_sort(numbers);

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        private static void Selection_sort(int[] numbers)
        {
            int i, j, min, temp;

            for (i = 0; i < numbers.Length - 1; i++)
            {
                min = i;

                for (j = i + 1; j < numbers.Length; j++)
                    if (numbers[j] < numbers[min]) 
                        min = j;

                temp = numbers[i];
                numbers[i] = numbers[min];
                numbers[min] = temp;
            }
        }
    }
}
