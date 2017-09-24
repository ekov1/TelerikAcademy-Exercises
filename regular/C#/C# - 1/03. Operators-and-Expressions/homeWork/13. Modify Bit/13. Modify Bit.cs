using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Modify_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            uint bitValue = uint.Parse(Console.ReadLine());

            int mask = 1 << position;

            if (bitValue == 0) mask = ~mask;

            if (bitValue == 1) number = number | (uint)mask;
            else number = number & (uint)mask;

            Console.WriteLine(number);
        }
    }
}
