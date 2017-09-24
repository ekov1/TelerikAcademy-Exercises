using System;

namespace _01.Numbers_from_1_to_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n + 1; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
