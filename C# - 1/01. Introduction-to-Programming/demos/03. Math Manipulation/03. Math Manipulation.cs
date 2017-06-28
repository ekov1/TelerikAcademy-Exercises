using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Math_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math.Abs(-7) = {0}", Math.Abs(-7));
            Console.WriteLine();
            Console.WriteLine("Square root of 9 is {0}", Math.Sqrt(9));
            Console.WriteLine();
            Console.WriteLine("Square of 10 is {0}", Math.Pow(10, 2));
            Console.WriteLine();
            Console.WriteLine("PI is {0}", Math.PI);
            Console.WriteLine();

            int width = 10,
                height = 4,
                area = width * height;

            Console.WriteLine("The area of a rectangle with width {0} and height {1} is {2}", width, height, area);
            Console.WriteLine();
        }
    }
}
