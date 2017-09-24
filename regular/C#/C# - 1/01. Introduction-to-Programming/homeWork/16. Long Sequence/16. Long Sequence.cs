using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Long_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = -3;
            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                a += 2;
                b -= 2;
            }
        }
    }
}
