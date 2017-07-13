using System;
using System.Linq;

namespace _02.Reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] letters = input.ToCharArray();
            letters = letters.Reverse().ToArray();

            string result = new string(letters);
            Console.WriteLine(result);
        }
    }
}
