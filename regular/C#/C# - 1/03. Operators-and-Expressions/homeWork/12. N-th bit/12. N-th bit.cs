using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.N_th_bit
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            int mask = 1 << position;
           // Console.WriteLine(mask);
            int bit = number & mask;
          //  Console.WriteLine(bit);
            bit = bit >> position;
            Console.WriteLine(bit);
        }
    }
}
