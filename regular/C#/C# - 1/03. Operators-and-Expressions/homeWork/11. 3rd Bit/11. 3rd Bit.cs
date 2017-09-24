using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._3rd_Bit
{
    class _3rd_Bit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(number, 2);
            //Console.WriteLine(binary);
            char thirdBit = ' ';
            if (binary.Length > 2)
            {
                thirdBit = binary[binary.Length - 3];
                Console.WriteLine(thirdBit);
            }
            else Console.WriteLine(0);
        }
    }
}
