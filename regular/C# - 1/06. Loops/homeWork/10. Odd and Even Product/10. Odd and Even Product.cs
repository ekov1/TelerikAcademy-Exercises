using System;
using System.Linq;

namespace _10.Odd_and_Even_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, pos;
            long productOdd = 1, productEven = 1;
            int[] numbers;
            string strNumbers;

            n = int.Parse(Console.ReadLine());
            strNumbers = Console.ReadLine();

            numbers = new int[n];
            numbers = strNumbers.Split(' ').Select(x => int.Parse(x)).ToArray();

            for (i = 0; i < numbers.Length; i++)
            {
                pos = i + 1;
                if (pos % 2 == 0) productEven *= numbers[i];
                else productOdd *= numbers[i];
            }

            if (productOdd == productEven)
                Console.WriteLine("yes {0}", productEven);
            else
                Console.WriteLine("no {0} {1}", productOdd, productEven);

        }
    }
}
