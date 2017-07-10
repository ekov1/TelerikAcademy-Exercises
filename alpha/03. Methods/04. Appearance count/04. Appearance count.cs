using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Appearance_count
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x,counter=0;
            int[] numbers;

            n = int.Parse(Console.ReadLine());
            numbers = new int[n];
            numbers = Console.ReadLine().Split(' ').Select(strNumber => int.Parse(strNumber)).ToArray();
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == x) counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
