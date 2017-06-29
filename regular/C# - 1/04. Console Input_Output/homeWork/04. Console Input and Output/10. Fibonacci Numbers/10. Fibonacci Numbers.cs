using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long fib0 = 0, fib1 = 1, fibx = 0;

            if (n == 1) Console.WriteLine(fib0);
            else if (n == 2) Console.WriteLine("0, 1");
            else
            {
                Console.Write("0, 1");
                for(int i = 0;i< n-2; i++)
                {
                    fibx = fib0 + fib1;
                    Console.Write(", {0}", fibx);
                    fib0 = fib1;
                    fib1 = fibx;
                }
            }

        }
    }
}
