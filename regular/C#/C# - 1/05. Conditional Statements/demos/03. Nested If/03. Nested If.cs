using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Nested_If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers (on separate lines).");

            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            if (first == second)
            {
                Console.WriteLine("These two numbers are equal.");
            }
            else
            {
                if (first > second)
                {
                    Console.WriteLine("The first number is greater.");
                }
                else
                {
                    Console.WriteLine("The second number is greater.");
                }
            }
        }
    }
}
