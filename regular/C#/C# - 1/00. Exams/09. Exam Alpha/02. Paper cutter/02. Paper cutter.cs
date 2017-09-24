using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Paper_cutter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[11];
            bool[] used = new bool[11];

            a[0] = 1;

            for (int i = 1; i < a.Length; i++)
            {
                a[i] = 2 * a[i - 1];
            }

            Array.Reverse(a);

            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}

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
                   for(int w = used.Length-1; w >= 0; w--)
                    {
                        
                        if (used[w] == false) Console.WriteLine("A{0}",w);
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
