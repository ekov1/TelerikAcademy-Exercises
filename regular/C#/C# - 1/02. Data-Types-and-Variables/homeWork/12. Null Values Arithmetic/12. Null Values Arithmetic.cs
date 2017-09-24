using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Null_Values_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            double? y = null;

            Console.WriteLine(x+1);
            Console.WriteLine(y+1);
        }
    }
}
