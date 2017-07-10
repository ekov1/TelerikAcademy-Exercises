using System;
using System.Linq;

namespace _06.First_larger_than_neighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, index = 0;
            int[] numbers;

            n = int.Parse(Console.ReadLine());
            numbers = new int[n];
            numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i - 1] < numbers[i] && numbers[i] > numbers[i + 1])
                {
                    index = i;
                    break;
                }

            }

            Console.WriteLine(index);
        }
    }
}
