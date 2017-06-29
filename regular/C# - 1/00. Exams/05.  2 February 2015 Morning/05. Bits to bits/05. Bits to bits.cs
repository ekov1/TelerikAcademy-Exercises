using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Bits_to_bits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] integers = new int[n];
            int i;
            for (i = 0; i < n; i++)
            {
                integers[i] = int.Parse(Console.ReadLine());
            }

            string[] bins = new string[n];
            for (i = 0; i < n; i++)
            {
                bins[i] = Convert.ToString(integers[i], 2).PadLeft(64, '0');
                 Console.WriteLine(bins[i]);
            }

            string mostOnes = "", mostZeroes = "";
            int ones = 0, zeros = 0, tempO, tempZ, bigOne = 0, bigZero = 0;

            for (i = 34; i < n; i++)
            {
                tempO = countOnes(bins[i]);
                //Console.WriteLine(tempO);
                tempZ = countZeros(bins[i]);

                if (tempO > ones)
                {
                    ones = tempO;
                    mostOnes = bins[i];
                    bigOne = integers[i];
                }

                if (tempZ > zeros)
                {
                    zeros = tempZ;
                    mostZeroes = bins[i];
                    bigZero = integers[i];
                }
            }
            //Console.WriteLine(mostZeroes);
            //Console.WriteLine(mostOnes);
            Console.WriteLine(zeros);
            Console.WriteLine(ones);
        }

        static int countOnes(string x)
        {
            Console.WriteLine(x.Length);
            int i, counter = 0, big = 0;
            for (i = 0; i < x.Length; i++)
            {
                if (x[i] == '1')
                {
                    counter++;
                }
                else
                {
                    if (counter > big) big = counter;
                    counter = 0;
                }
            }
            return big;
        }
        static int countZeros(string x)
        {
            int i, counter = 0, big = 0;
            for (i = 34; i < x.Length; i++)
            {
                if (x[i] == '0')
                {
                    counter++;
                }
                else
                {
                    if (counter > big) big = counter;
                    counter = 0;
                }
            }
            return big;
        }
    }
}
