using System;
using System.Linq;

namespace _08.Number_as_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberOne, numberTwo, sizes, result;
            int big, small;

            sizes = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            big = Math.Max(sizes[0], sizes[1]);
            small = Math.Min(sizes[0], sizes[1]);

            numberOne = new int[sizes[0]];
            numberTwo = new int[sizes[1]];
            result = new int[big + 1];

            numberOne = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            numberTwo = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            for (int i = 0; i < big; i++)
            {
                if (i < small)
                {
                    result[i] += numberOne[i] + numberTwo[i];

                    if (result[i] > 9)
                    {
                        result[i + 1] += 1;
                        result[i] = result[i] - 10;
                    }
                }
                else
                {
                    if (numberOne.Length > numberTwo.Length)
                        result[i] += numberOne[i];
                    else
                        result[i] += numberTwo[i];
                }
            }

            for (int i = 0; i < big; i++)
            {
                if (i != big - 1)
                    Console.Write("{0} ", result[i]);
                else
                    Console.Write("{0}", result[i]);
            }
        }
    }
}
