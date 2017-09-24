using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Divide_by_7_and_5
{
    class Divide_by_7_and_5
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string result = "";

            if (number % 5 == 0 && number % 7 == 0) result += "true " + number;
            else result += "false " + number;

            Console.WriteLine(result);
        }
    }
}
