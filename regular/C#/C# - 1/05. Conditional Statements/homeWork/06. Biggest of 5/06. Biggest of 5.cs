using System;

namespace _06.Biggest_of_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[5];

            for (int i = 0; i < 5; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            Console.WriteLine(numbers[4]);
        }
    }
}
