﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace fibonacci
{
    class fibonacci
    {
        static int n = 100000;
        static int[] memo = new int[n];
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            for (int i = 0; i < n; i++)
            {
                stopwatch.Start();
                Console.Write("Fibonacci " + i + " : " + Fibonacci(i) + " ");
                Console.WriteLine(stopwatch.ElapsedMilliseconds / 1000 + " seconds passed");
                //  Console.WriteLine(stopwatch.ElapsedMilliseconds  + " milliseconds passed");
            }
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
          //  number %= 1000000007;
            memo[n] = number;
            return number;
        }
    }
}
