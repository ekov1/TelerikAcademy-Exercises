using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Third_Bit_v2_bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int mask = 1 << 3;
            Console.WriteLine(mask);
            int bit = number & mask;
            Console.WriteLine(bit);
            bit = bit >> 3;
            Console.WriteLine(bit);
        }
    }
}
