using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Formatting_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double result = a * b * c;

            Console.WriteLine("{0,10} | {1,10} | {2,10} | {3,10}", "a", "b", "c", "a hex");
            Console.WriteLine("{0,10} | {1,10} | {2,10} | {3,10}", a, b, c, result);

            Console.WriteLine("The hex of {0} is {0:X}", a);
            Console.WriteLine("The binary of {0} is {1}",a, Convert.ToString(a,2).PadLeft(16));
            Console.WriteLine("b with 2 digit after the decimal point {0:F2}",b);
        }
    }
}
