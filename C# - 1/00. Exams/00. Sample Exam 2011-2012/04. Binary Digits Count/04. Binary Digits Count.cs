using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Binary_Digits_Count
{
    class Binary_Digits_Count
    {
        static void Main(string[] args)
        {
            uint digit = uint.Parse(Console.ReadLine());
            uint n = uint.Parse(Console.ReadLine());
            
            for (uint i = 0; i < n; i++)
            {
                uint number = uint.Parse(Console.ReadLine());
                uint count = bitCounter(number, digit);
                Console.WriteLine(count);
            }
        }

        static uint bitCounter(uint x, uint digit)
        {
            uint counter = 0;
            int length = Convert.ToString(x, 2).Length;

            for (int i = 0; i < length; i++)
            {
                int mask = 1;
                if (i > 0)
                    mask = 1 << i;
                long bit = x & mask;
                if (i > 0)
                    bit = bit >> i;
               // Console.WriteLine(bit);
                if (bit == digit) counter++;
            }

            return counter;
        }
    }
}
