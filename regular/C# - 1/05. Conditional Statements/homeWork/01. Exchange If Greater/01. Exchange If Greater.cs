using System;

namespace _01.Exchange_If_Greater
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a < b)
                Console.WriteLine(a + " " + b);
            else
                Console.WriteLine(b + " " + a);
        }
    }
}
