using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Declare_Variables
{
    class Declare_Variables
    {
        static void Main(string[] args)
        {
            /*
            Declare five variables choosing for each of them the most appropriate of the types 
            byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 
            52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure 
            it will fit in it. Try to compile the code.
            */

            sbyte sb = -115; // -128 --- 127 = 2^7 -1
            byte b = 97; // 0 --- 255 2^8 -1
            short s = -10000; // 
            ushort us = 52130;
            int i = 48259320;
        }
    }
}
