using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        /// <summary>
        /// Write a program that reads N integers from the console and reverses them using a stack.
        /// Use the Stack<int> class.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();

            Console.WriteLine("enter n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("enter n numbers");
            for (int i = 0; i < n; i++)
            {
                numbers.Push(int.Parse(Console.ReadLine()));
            }

            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Pop());
            }
        }
    }
}
