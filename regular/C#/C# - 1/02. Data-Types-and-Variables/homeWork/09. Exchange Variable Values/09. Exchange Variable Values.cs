using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10, c;

            Console.WriteLine("a = {0}, b = {1}",a,b);

            if (a != 10)
            {
                c = a;
                a = b;
                b = c;
            }

            Console.WriteLine("exchange a = {0}, b = {1}", a, b);
        }
    }
}
