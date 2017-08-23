using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    /// <summary>
    /// Write a program that removes from given sequence all numbers that occur odd number of times.
    /// Example:
    /// {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            List<int> odd = new List<int>();
            List<int> found = new List<int>();

            int counter = 0;
            int numToCeck;


            foreach (var number in numbers)
            {
                numToCeck = number;
                foreach (var num in numbers)
                {
                    if (numToCeck == num)
                    {
                        counter++;
                    }
                }

                if (counter % 2 == 0)
                {
                    odd.Add(numToCeck);
                }
                counter = 0;
            }

            Console.WriteLine(string.Join(" ", odd));
        }
    }
}
