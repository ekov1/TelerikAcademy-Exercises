using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_for
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Fibbonacii(long.Parse(Console.ReadLine())));
        }

        static long Fibbonacii(long n)
        {
            long answer = 0;

            long f1 = 1;
            long f2 = 1;
            long temp = 0;

            if (n == 1 || n == 2)
            {
                return 1;
            }

            for (int i = 2; i < n; i++)
            {
                temp = f1 + f2;
                f1 = f2;
                f2 = temp;
            }
            answer = f2;

            return answer;
        }
    }
}
