using System;

namespace _04.Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;

            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());

            if (a == 0 || b == 0 || c == 0)
                Console.WriteLine(0);

            if (a > 0 && b > 0 && c > 0)
                Console.WriteLine("+");

            if (a > 0 && b > 0 && c < 0)
                Console.WriteLine("-");
            if (a > 0 && b < 0 && c > 0)
                Console.WriteLine("-");
            if (a < 0 && b > 0 && c > 0)
                Console.WriteLine("-");

            if (a > 0 && b < 0 && c < 0)
                Console.WriteLine("+");
            if (a < 0 && b < 0 && c > 0)
                Console.WriteLine("+");
            if (a < 0 && b > 0 && c < 0)
                Console.WriteLine("+");

            if (a < 0 && b < 0 && c < 0)
                Console.WriteLine("-");
        }
    }
}
