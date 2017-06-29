using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = w * h;
            double p = 2 * (w + h);

            Console.WriteLine("{0:F2} {1:F2}", area, p);
        }
    }
}
