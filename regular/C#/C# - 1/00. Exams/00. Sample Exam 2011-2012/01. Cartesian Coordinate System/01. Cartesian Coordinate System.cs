using System;

namespace _01.Cartesian_Coordinate_System
{
    class Cartesian_Coordinate_System
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0) Console.WriteLine(1); // 1
            else if (x < 0 && y > 0) Console.WriteLine(2); // 2
            else if (x < 0 && y < 0) Console.WriteLine(3); // 3
            else if (x > 0 && y < 0) Console.WriteLine(4); // 4
            else if (x == 0 && y != 0) Console.WriteLine(5); // 5
            else if (x != 0 && y == 0) Console.WriteLine(6); // 6
            else if (x == 0 && y == 0) Console.WriteLine(0); // 0
        }
    }
}
