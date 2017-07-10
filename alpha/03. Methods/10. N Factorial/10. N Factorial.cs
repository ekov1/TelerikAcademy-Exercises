using System;
using System.Numerics;

namespace _10.N_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string vhod = Console.ReadLine();
            fac(vhod);
        }
        static void fac(string vhod)
        {
            int n, i;
            BigInteger factorial = 1;
            n = int.Parse(vhod);

            if (n > 0)
            {
                for (i = 1; i <= n; i++)
                {
                    factorial *= i;
                }
            }
            else
                factorial = 1;
            Console.WriteLine(factorial);

        }
    }
}
