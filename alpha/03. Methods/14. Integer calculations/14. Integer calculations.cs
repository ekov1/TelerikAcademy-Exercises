using System;
using System.Linq;

namespace _14.doubleeger_calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            double min = double.MaxValue, max = double.MinValue, sum = 0, product = 1, avrg = 0;

            double[] numbers = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();

            foreach (double num in numbers)
            {
                min = Math.Min(min, num);
                max = Math.Max(max, num);
                sum += num;
                product *= num;
            }

            avrg = sum / numbers.Length;

            Console.WriteLine("{0}", min);
            Console.WriteLine("{0}", max);
            Console.WriteLine("{0:F2}", avrg);
            Console.WriteLine("{0}", sum);
            Console.WriteLine("{0}", product);
        }
    }
}
