using System;

namespace _05.Calculate_
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, x, sum = 1, factorial = 1, i = 1;

            n = double.Parse(Console.ReadLine());
            x = double.Parse(Console.ReadLine());

            while (i <= n)
            {
                factorial *= i;
                sum += factorial / Math.Pow(x, i);
                i++;
            }
            Console.WriteLine("{0:0.00000}", sum);
        }
    }
}

