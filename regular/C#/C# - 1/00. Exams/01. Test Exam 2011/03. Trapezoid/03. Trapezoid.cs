using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Trapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,
               n = int.Parse(Console.ReadLine());

            string s = new string('.', n)+ new string('*', n);
            Console.WriteLine(s);

            for (i=1;i< n; i++)
            {
                s = new string('.', n - i) + "*" + new string('.', n + i-2) + "*";
                Console.WriteLine(s);
            }

            s = new string('*', n*2 );
            Console.WriteLine(s);
        }
    }
}
