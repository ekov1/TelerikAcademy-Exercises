using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_memo
{
    class Program
    {
        const int MOD = 1000000007;
        static int[] memo;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            memo = new int[n + 1];

            Console.WriteLine(Fibonacci(n));
        }

        static int Fibonacci(int n)
        {
            if (memo[n] != 0)
            {
                return memo[n];
            }

            if (n == 0)
            {
                return 0;
            }

            if (n == 1 || n == 2)
            {
                return 1;
            }

            int number = Fibonacci(n - 1) + Fibonacci(n - 2);
            number %= MOD;
            memo[n] = number;

            return number;
        }
    }
}
