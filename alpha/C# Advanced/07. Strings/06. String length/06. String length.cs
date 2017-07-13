using System;

namespace _06.String_length
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().PadRight(20, '*');
            Console.WriteLine(input);
        }
    }
}
