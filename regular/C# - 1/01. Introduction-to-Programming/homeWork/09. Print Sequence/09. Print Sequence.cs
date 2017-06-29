using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Print_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = -3;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                a += 2;
                b -= 2;
            }
        }
    }
}
