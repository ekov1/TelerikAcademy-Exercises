using System;

namespace _03.MMSA_of_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double min = double.MaxValue, max = double.MinValue, sum = 0, avrg = 0;

            int n = int.Parse(Console.ReadLine());

            double[] numbers = new double[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());

                min = Math.Min(min, numbers[i]);
                max = Math.Max(max, numbers[i]);
                sum += numbers[i];
            }

            avrg = sum / numbers.Length;

            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", avrg);

        }
    }
}
