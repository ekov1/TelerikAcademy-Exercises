using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        /// <summary>
        /// Write a program that removes from given sequence all negative numbers.
        /// </summary>

        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, -6, 1, 1, 2, 2, -23, -45, -18, 5, 5, 5, -45, -18, -23, 5, 5, 6, 7 };
            Console.WriteLine(string.Join(", ", numbers));

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.Remove(numbers[i]);
                    i--;
                }
            }

            //foreach (var number in numbers)
            //{
            //    if (number < 0)
            //    {
            //        numbers.Remove(number);
            //    }
            //}

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
