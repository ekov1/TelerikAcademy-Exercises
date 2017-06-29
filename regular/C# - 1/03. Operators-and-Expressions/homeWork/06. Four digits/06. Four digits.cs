using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Four_digits
{
    class Four_digits
    {
        static void Main(string[] args)
        {
            int number, dg1, dg2, dg3, dg4;
            number = int.Parse(Console.ReadLine());

            dg1 = number / 1000;
            // Console.WriteLine(dg1);

            dg2 = (number % 1000) / 100;
            // Console.WriteLine(dg2);

            dg3 = ((number % 1000) % 100) / 10;
            //Console.WriteLine(dg3);

            dg4 = ((number % 1000) % 100) % 10;
            //Console.WriteLine(dg4);

            Console.WriteLine(dg1 + dg2 + dg3 + dg4);
            Console.WriteLine("{0}{1}{2}{3}", dg4, dg3, dg2, dg1);
            Console.WriteLine("{0}{1}{2}{3}", dg4, dg1, dg2, dg3);
            Console.WriteLine("{0}{1}{2}{3}", dg1, dg3, dg2, dg4);

        }
    }
}
