using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Point_in_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, dis;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            dis = Math.Sqrt(x * x + y * y);

            if (dis <= 2)
                Console.WriteLine("yes {0:F2}", dis);
            else
                Console.WriteLine("no {0:F2}", dis);

        }
    }
}
