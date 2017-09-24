using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Reading_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Key name: " + key.Key);
            Console.WriteLine("Key number: " + (int)key.Key);
            Console.WriteLine("Special keys: [{0}] ", key.Modifiers);
            Console.WriteLine("Character entered: " + key.KeyChar);
        }
    }
}
