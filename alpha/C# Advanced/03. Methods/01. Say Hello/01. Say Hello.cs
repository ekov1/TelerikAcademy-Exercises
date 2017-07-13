using System;

namespace _01.Say_Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            name = Console.ReadLine();

            Say_Hello(name);
        }

        private static void Say_Hello(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}
