using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Moon_Gravity
{
    class Moon_Gravity
    {
        static void Main(string[] args)
        {
            double wE = double.Parse(Console.ReadLine());
            double wM = (wE / 100) * 17;
            Console.WriteLine("{0:F3}", wM);
        }
    }
}
