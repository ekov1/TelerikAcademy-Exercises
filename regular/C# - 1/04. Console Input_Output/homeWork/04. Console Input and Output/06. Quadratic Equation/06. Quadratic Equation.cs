using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double result;

            double D = Math.Pow(b, 2) - (4 * a * c);

            if (D < 0)
            {
                Console.WriteLine("no real roots");
            }
            else if (D == 0)
            {
                result = (-b) / (2 * a);
                Console.WriteLine("{0:F2}", result);
            }
            else {
                result = ((-b) - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("{0:F2}", result);
                result = ((-b) + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("{0:F2}", result);
            }
        }
    }
}
