using System;
using System.Linq;

namespace _02.Get_largest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            numbers = new int[3];
            numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int big = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                big = GetMax(big, numbers[i]);
            }

            Console.WriteLine(big);

        }

        private static int GetMax(int big, int x)
        {
            if (big < x)
                big = x;

            return big;
        }
    }
}
