using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.N_th_bit_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong ulN, ulP;

            ulP = ulong.Parse(Console.ReadLine());
            ulN = ulong.Parse(Console.ReadLine());

            ulong umask = (ulong)Math.Pow(2, ulN);

            ulP = ulP & umask;


            if (ulP == umask)
            {
                Console.WriteLine(1);
            }
            else
                Console.WriteLine(0);
        }
    }
}
