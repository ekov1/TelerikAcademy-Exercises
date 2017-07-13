using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Maximal_increasing_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, seq = 1, maxSeq = 1;
            int[] numbers;

            n = int.Parse(Console.ReadLine());
            numbers = new int[n];

            for (i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < n - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                    seq++;
                else
                {
                    if (seq > maxSeq)
                        maxSeq = seq;

                    seq = 1;
                }
            }

            if (seq > maxSeq)
                maxSeq = seq;

            Console.WriteLine(maxSeq);
        }
    }
}
