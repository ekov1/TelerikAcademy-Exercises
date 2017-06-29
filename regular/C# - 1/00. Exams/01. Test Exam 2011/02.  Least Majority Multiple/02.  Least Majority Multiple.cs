using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Least_Majority_Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = int.Parse(Console.ReadLine());
            numbers[1] = int.Parse(Console.ReadLine());
            numbers[2] = int.Parse(Console.ReadLine());
            numbers[3] = int.Parse(Console.ReadLine());
            numbers[4] = int.Parse(Console.ReadLine());

            Array.Sort(numbers);

            Console.WriteLine();

            int result = 0, counter = 0;

            for (int i = 4; i < 1000000; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i % numbers[j] == 0)
                    {
                        counter++;
                    }

                }
                if (counter >= 3)
                {
                    result = i;
                    break;
                }
                else
                {
                    counter = 0;
                }

            }
            Console.WriteLine(result);
        }
    }
}
