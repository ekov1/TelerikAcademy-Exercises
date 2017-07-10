using System;
using System.Linq;

namespace _07.Reverse_number
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] number = Console.ReadLine().ToCharArray();
            number = number.Reverse().ToArray();

            foreach (var item in number)
            {
                Console.Write(item);
            }
        }
    }
}
