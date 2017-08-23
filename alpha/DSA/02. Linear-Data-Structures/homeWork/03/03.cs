using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        /// <summary>
        /// Write a program that reads a sequence of integers (List<int>) 
        /// ending with an empty line and sorts them in an increasing order.
        /// </summary>

        static void Main(string[] args)
        {
            string input = "123456";
            int num;
            List<int> numbers = new List<int>();

            while (!string.IsNullOrEmpty(input))
            {
                input = Console.ReadLine();

                if (input.Length > 0)
                {
                    num = int.Parse(input);
                    numbers.Add(num);
                }
            }

            numbers.Sort();
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
