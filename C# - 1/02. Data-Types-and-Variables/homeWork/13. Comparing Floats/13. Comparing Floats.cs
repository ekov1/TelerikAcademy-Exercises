using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Comparing_Floats
{
    class Comparing_Floats
    {
        static void Main(string[] args)
        {
            float eps = 0.000001f;

            //float a = 5.3f;
            //float b = 6.01f;

            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            float a = (float)Convert.ToDouble(num1);
            float b = (float)Convert.ToDouble(num2);

            float diff = Math.Abs(a - b);
            
            if (diff < eps)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
}
