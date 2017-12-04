using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Maximal_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new int[] { 1, 2, 3 };
            var a = x;

            Console.WriteLine(x[0]);
            a[0] = 2;
            Console.WriteLine(x[0]);

            int[] y = { 2, 3, 3, 3, 4, };

            int[] z = (int[])x.Clone();
            Console.WriteLine(z[0]);
            z[0] = 2222;
            Console.WriteLine(z[0]);
        }
    }
}
