using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Larger_than_neighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, counter = 0;
            int[] numbers;

            n = int.Parse(Console.ReadLine());
            numbers = new int[n];
            numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i - 1] < numbers[i] && numbers[i] > numbers[i + 1])
                    counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
