using System;
using System.Numerics;

namespace _07.Calculate_3_
{
    class Program
    {
        static void Main(string[] args)
        {
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
