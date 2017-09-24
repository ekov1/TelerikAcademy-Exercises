using System;

namespace _02.Compare_arrays
{
    // Description

    // Write a program that reads two integer arrays of size N from the console
    // and compares them element by element.
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] numbers, numbers2;

            n = int.Parse(Console.ReadLine());
            numbers = new int[n];
            numbers2 = new int[n];

            RecordArray(numbers);
            RecordArray(numbers2);

            bool answer = CheckIfSame(numbers, numbers2);

            if (answer == true)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");

        }

        private static bool CheckIfSame(int[] numbers, int[] numbers2)
        {
            int n = numbers.Length,
                 i;

            for (i = 0; i < n; i++)
            {
                if (numbers[i] != numbers2[i])
                    return false;
            }

            return true;
        }

        private static void RecordArray(int[] numbers)
        {
            int n = numbers.Length,
                i;

            for (i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
