using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Console_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WindowHeight = 30;
            Console.WindowWidth = 100;

            Console.WriteLine("Hello");
            Console.WriteLine("WorkShop!");

            int result = 3 / 1;
            Console.WriteLine(result);

            //Console.Clear();
        }
    }
}
