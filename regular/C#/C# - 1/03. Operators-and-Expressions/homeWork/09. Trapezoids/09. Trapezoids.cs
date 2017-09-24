using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, h;
            double area;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            h = double.Parse(Console.ReadLine());

            area = h * ((a + b) / 2);
            Console.WriteLine("{0:F7}", area);
        }
    }
}
