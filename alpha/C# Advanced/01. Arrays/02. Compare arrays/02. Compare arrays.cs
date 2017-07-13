using System;

namespace _02.Compare_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            string result = "Equal";

            for (int i = 0; i < n; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    result = "Not equal";
                    break;
                }

            }

            Console.WriteLine(result);
        }
    }
}
