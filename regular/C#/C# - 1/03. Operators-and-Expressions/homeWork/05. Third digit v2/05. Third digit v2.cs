using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Third_digit_v2
{
    class Third_digit_v2
    {
        static void Main(string[] args)
        {
            int a = 1, a10, a100;
            a = int.Parse(Console.ReadLine());

            a100 = a / 100;
             Console.WriteLine(a100);

            a10 = a100 % 10;
              Console.WriteLine(a10);

            if (a10 == 7)
                Console.WriteLine("true");
            else
                Console.WriteLine("false " + a10);
        }
    }
}
