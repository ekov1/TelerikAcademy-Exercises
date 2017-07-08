using System;
using System.Numerics;

namespace _08.Catalan_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n, resultCatalan;

            n = BigInteger.Parse(Console.ReadLine());

            resultCatalan = CalculateFactorial(2 * n) / (CalculateFactorial(n+1)*CalculateFactorial(n));

            Console.WriteLine(resultCatalan);
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
