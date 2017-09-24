using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Try_Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int number;
            if (int.TryParse(str, out number))
            {
                Console.WriteLine("Valid number: {0}", number);
            }
            else
            {
                Console.WriteLine("Invalid number: {0}", str);
            }
        }
    }
}
