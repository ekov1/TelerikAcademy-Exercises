using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Integer_Types
{
    class Integers
    {
        static void Main(string[] args)
        {
            byte centuries = 20; // usually a small number
            ushort years = 2000;
            uint days = 730480;
            ulong hours = 17531520;

            Console.WriteLine(
                "{0} centuries is {1} years, or {2} days, or {3} hours",
                centuries, years, days, hours
                );
        }
    }
}
