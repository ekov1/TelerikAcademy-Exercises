using System;

namespace Point3D
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Point3D some = new Point3D(0, 1, 2);

            Console.WriteLine(some.ToString());

            Point3D pO = Point3D.PointO;

            Console.WriteLine(pO.ToString());

            Path someP = new Path();

            someP.PointsList.Add(some);

            foreach(var p in someP.PointsList)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
