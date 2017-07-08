using System;

namespace _12.Decimal_to_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            long A = 0;
            string result = "";

            A = long.Parse(Console.ReadLine());

            while (A != 0)
            {
                if (A % 2 == 0)
                    result = "0" + result;
                else
                    result = "1" + result;
                A = A / 2;

            }

            if (result == "") result = "0";

            Console.WriteLine(result);
        }
    }
}
