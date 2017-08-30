using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    /// <summary>
    /// Write a program that finds in given array of integers (all belonging to the range [0..1000]) 
    /// how many times each of them occurs.
    /// Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
    /// 2 → 2 times
    /// 3 → 4 times
    /// 4 → 3 times
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            int[] counter = new int[10];

            foreach (var num in arr)
            {
                counter[num]++;
            }

            for (int i = 0; i < counter.Length; i++)
            {
                if (counter[i] > 0)
                {
                    Console.WriteLine("{0} -> {1} times", i, counter[i]);
                }
            }
        }
    }
}
