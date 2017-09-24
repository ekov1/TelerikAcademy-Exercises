using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Odd_or_Even
{
    class Odd_or_Even
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string result = "";

            if (number % 2 != 0) result += "odd ";
            else result += "even ";

            Console.WriteLine(result + number);
        }
    }
}
