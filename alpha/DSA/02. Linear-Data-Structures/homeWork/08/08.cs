using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    /// <summary>
    /// *The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
    ///  - Write a program to find the majorant of given array(if exists).
    ///  - Example:
    ///    - `{2, 2, 3, 3, 2, 3, 4, 3, 3}` &rarr; `3`
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            Dictionary<int, int> counter = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!counter.ContainsKey(numbers[i]))
                {
                    counter.Add(numbers[i], 1);
                }
                else
                {
                    counter[numbers[i]]++;
                }
            }

            foreach (var item in counter)
            {
                Console.WriteLine("key: {0}, value: {1}",item.Key,item.Value);
            }

            int big = 0;
            int key = 0;
            foreach (var item in counter)
            {
                if (item.Value > big)
                {
                    big = item.Value;
                   // Console.WriteLine(big);
                    key = item.Key;
                   // Console.WriteLine(key);
                }
            }

            if (counter[key]>= (numbers.Length / 2) + 1)
            {
                Console.WriteLine(key);
            }
            else
            {
                Console.WriteLine("not");
            }
        }
    }
}
