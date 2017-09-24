using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Strings
{
    class Strings
    {
        static void Main(string[] args)
        {
            string firstName = "Gosho";
            string lastName = "Goshev";
            Console.WriteLine("Hello, {0}!\n", firstName);

            string fullname = firstName + " " + lastName;
            Console.WriteLine("Your full name is {0}.", fullname);
        }
    }
}
