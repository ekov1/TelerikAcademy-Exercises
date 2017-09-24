using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Floating_Point_Types
{
    class FloatingPointTypes
    {
        static void Main(string[] args)
        {
            float floatPI = 3.141592653589793238f;
            double doublePI = 3.141592653589793238;

            Console.WriteLine("Float PI is {0}", floatPI);
            Console.WriteLine("Double PI is {0}", doublePI);
            Console.WriteLine();

            // Example of Comparison abnormality
            double a = 1.0f;
            double b = 0.33f;
            double sum = 1.33f;
            bool equal = ((a + b) == sum);
            Console.WriteLine("a is {0}, b is {1}", a, b);
            Console.WriteLine("Float calculation: a + b = {0}, sum = {1}, equal = {2}", (a + b), sum, equal);
            Console.WriteLine();

            // decimal numbers do not have comparison abnormalities
            decimal aDecimal = 1.0M;
            decimal bDecimal = 0.33M;
            decimal sumDecimal = 1.33M;
            bool equalDecimal = ((aDecimal + bDecimal) == sumDecimal);
            Console.WriteLine("a is {0}, b is {1}", aDecimal, bDecimal);
            Console.WriteLine("Float calculation: a + b = {0}, sum = {1}, equal = {2}", (aDecimal + bDecimal), sumDecimal, equalDecimal);
            Console.WriteLine();
        }
    }
}
