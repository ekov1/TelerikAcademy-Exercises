using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Ship_Damage
{
    class Program
    {
        static void Main(string[] args)
        {
            int SX1 = int.Parse(Console.ReadLine()),
                SY1 = int.Parse(Console.ReadLine()),
                SX2 = int.Parse(Console.ReadLine()),
                SY2 = int.Parse(Console.ReadLine()),
                H = int.Parse(Console.ReadLine()),
                CX1 = int.Parse(Console.ReadLine()),
                CY1 = int.Parse(Console.ReadLine()),
                CX2 = int.Parse(Console.ReadLine()),
                CY2 = int.Parse(Console.ReadLine()),
                CX3 = int.Parse(Console.ReadLine()),
                shot1 = -CY1 + H,
                shot2 = -CY2 + H,
                shot3 = -CY3 + H,
                dmg=0;

            if((shot1 == SY1 && CX1 == SX1))

        }
    }
}
