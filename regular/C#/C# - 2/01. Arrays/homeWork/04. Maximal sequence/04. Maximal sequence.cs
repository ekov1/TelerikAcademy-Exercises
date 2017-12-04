using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Maximal_sequence
{
    class Program
    {
        /// <summary>
        /// Write a program that finds the length of the maximal sequence
        /// of equal elements in an array of N integers.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n;
            int currentNum;
            int newNum;
            int curSeq = 1;
            int maxSeq = 1;

            n = int.Parse(Console.ReadLine());
            currentNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                newNum = int.Parse(Console.ReadLine());
                if (currentNum == newNum)
                {
                    curSeq++;
                }
                else
                {
                    currentNum = newNum;

                    if (curSeq > maxSeq)
                    {
                        maxSeq = curSeq;
                    }
                    curSeq = 1;
                }
            }

            if (curSeq > maxSeq)
            {
                maxSeq = curSeq;
            }

            Console.WriteLine(maxSeq);
        }
    }
}
