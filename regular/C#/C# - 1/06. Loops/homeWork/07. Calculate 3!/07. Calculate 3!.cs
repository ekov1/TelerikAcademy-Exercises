using System;
using System.Numerics;

namespace _07.Calculate_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n, k, resultNK;

            n = BigInteger.Parse(Console.ReadLine());
            k = BigInteger.Parse(Console.ReadLine());

            resultNK = CalculateFactorial(n) / (CalculateFactorial(k) * CalculateFactorial(n - k));

            Console.WriteLine(resultNK);
        }

        private static BigInteger CalculateFactorial(BigInteger i)
        {
            BigInteger factorial = 1;

            while (true)
            {
                if (i == 1)
                    break;

                factorial *= i;
                i--;
            }

            return factorial;
        }
    }
}
