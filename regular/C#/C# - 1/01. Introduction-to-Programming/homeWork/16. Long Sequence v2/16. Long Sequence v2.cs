using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Long_Sequence_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToPrint, members = 0;

            for (int i = 2; i < 1002; i++)
            {
                if (i % 2 == 0)
                    numberToPrint = i;
                else
                    numberToPrint = i * (-1);

                Console.WriteLine(numberToPrint);
                members++;
            }
            Console.WriteLine("sequence has " + members + " members");
        }
    }
}
