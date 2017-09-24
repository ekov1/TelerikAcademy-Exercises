using System;

namespace _02.Not_Divisible_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n + 1; i++)
            {
                if (i % 3 != 0 & i % 7 != 0)
                    Console.Write(i + " ");
            }
        }
    }
}
