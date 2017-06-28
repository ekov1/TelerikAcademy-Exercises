using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Reading_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Hello, {0} {1}!", firstName, lastName);
        }
    }
}
