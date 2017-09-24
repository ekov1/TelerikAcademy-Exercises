using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Boolean_Type
{
    class Booleans
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            bool aGreaterThanB = (a > b);
            Console.WriteLine("a is {0}, b is {1}, (a > b) = {2}", a, b, aGreaterThanB);
            Console.WriteLine();

            bool doesAEqualOne = (a == 1);
            Console.WriteLine("(a == 1) = {0}",doesAEqualOne);
            Console.WriteLine();
        }
    }
}
