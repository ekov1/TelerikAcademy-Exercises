using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_of_5_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            for(int i = 0; i < 5; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
