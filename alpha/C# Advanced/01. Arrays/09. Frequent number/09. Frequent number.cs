using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Frequent_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, num, tempNumCount, bestNum = 0;
            int[] numbers;

            n = int.Parse(Console.ReadLine());
            numbers = new int[n];

            for (i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);


            for (i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
