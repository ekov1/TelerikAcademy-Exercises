using System;

namespace _05.Biggest_of_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[3];

            for (int i = 0; i < 3; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            Console.WriteLine(numbers[2]);
        }
    }
}
