using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Comparing_Floats_v2
{
    class Comparing_Floats_v2
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double diff = Math.Abs(a - b);

            if(diff < eps)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
}
