using System;
using System.Numerics;

namespace _06.Calculate_Again_
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n, k,result;
            
            n = BigInteger.Parse(Console.ReadLine());
            k = BigInteger.Parse(Console.ReadLine());

            result = CalculateFactorial(n) / CalculateFactorial(k);

            Console.WriteLine(result);
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
