using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Math_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            double a = (n * n) + (1 / (m * p)) + 1337;
            double b = n - (128.523123123 * p);
            double c = Math.Sin((int)m % 180);

            double result = (a / b) + c;

            Console.WriteLine("{0:F6}",result);
        }
    }
}
