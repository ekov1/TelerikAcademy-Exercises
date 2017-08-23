using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        /// <summary>
        /// Write a program that reads from the console a sequence of positive integer numbers.
        /// The sequence ends when empty line is entered.
        /// Calculate and print the sum and average of the elements of the sequence.
        ///  Keep the sequence in List<int>.
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

            double sum = 0;
            double avg = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            avg = sum / numbers.Count();

            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0}", avg);
        }
    }
}
