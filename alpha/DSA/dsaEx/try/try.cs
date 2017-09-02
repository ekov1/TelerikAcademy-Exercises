using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @try
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<int> digits = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ').ToArray();

                int dig1 = int.Parse(line[0]);
                int dig2 = int.Parse(line[3]);
                string condition = line[2];

            }

            int combinations = (int)Math.Pow(2, 11);

            for (int i = 1; i < combinations; i++)
            {
                int tempSum = 0;
                for (int j = 0; j < 11; j++)
                {
                    int mask = 1 << j;
                    int iAndMask = mask & i;
                    int bit = iAndMask >> j;

                    if (bit == 1)
                    {
                        tempSum += a[j];
                        used[j] = true;
                    }
                }

                if (tempSum == n)
                {
                    for (int w = used.Length - 1; w >= 0; w--)
                    {

                        if (used[w] == false) Console.WriteLine("A{0}", w);
                    }
                }
                else
                {
                    for (int b = 0; b < 11; b++)
                    {
                        used[b] = false;
                    }
                }


            }
        }
    }
}
