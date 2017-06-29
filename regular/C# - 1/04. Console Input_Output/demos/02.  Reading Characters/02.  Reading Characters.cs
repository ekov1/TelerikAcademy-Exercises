using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reading_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = Console.Read();
            char ch = (char)i;  // Cast the int value to char
            Console.WriteLine("The code of '{0}' is {1}.", ch, i);

            i = Console.Read();
            ch = (char)i;
            Console.WriteLine("The code of '{0}' is {1}.", ch, i);
        }
    }
}
