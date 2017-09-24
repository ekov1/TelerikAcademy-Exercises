using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Third_digit
{
    class Third_digit
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            string result = "";

            if (number.Length > 2 && number[number.Length-3] == '7') result += "true";
            else if (number.Length > 2 && number[number.Length - 3] != '7') result += "false " + number[number.Length - 3];
            else result += "false 0";

            Console.WriteLine(result);
        }
    }
}
