using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Prime_Check
{
    class Prime_Check
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a == 0 || a == 2 || a == 3 || a == 5 || a == 7)
            {
                Console.WriteLine("true");
            }
            else
               if (a % 2 == 0 || a % 3 == 0 || a % 5 == 0 || a % 7 == 0)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
