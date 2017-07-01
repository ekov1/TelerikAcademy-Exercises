using System;

namespace _07.Sort_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            BubbleSort(numbers);

            for (int i = 0; i < 3; i++)
            {
                Console.Write(numbers[i]+" ");
            }
        }

        private static void BubbleSort(int[] numbers)
        {
            int i, j, temp;

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
