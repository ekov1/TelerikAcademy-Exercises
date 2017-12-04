using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Maximal_Increasing_Sequence
{
    class Program
    {
        /// <summary>
        /// Maximal increasing sequence

        ///Description
        ///
        ///Write a program that finds the length of the maximal increasing sequence in an array of N integers.
        ///
        ///Input
        ///
        ///On the first line you will receive the number N
        ///On the next N lines the numbers of the array will be given
        ///Output
        ///
        ///Print the length of the maximal increasing sequence
        ///Constraints
        ///
        /*1 <= N <= 1024
       Time limit: 0.1s
       Memory limit: 16MB */
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n;
            int previousNum;
            int newNum;
            int curSeq = 1;
            int maxSeq = 1;

            n = int.Parse(Console.ReadLine());
            previousNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                newNum = int.Parse(Console.ReadLine());
                if (previousNum < newNum)
                {
                    curSeq++;
                }
                else
                {
                    if (curSeq > maxSeq)
                    {
                        maxSeq = curSeq;
                    }
                    curSeq = 1;
                }
                previousNum = newNum;
            }

            if (curSeq > maxSeq)
            {
                maxSeq = curSeq;
            }

            Console.WriteLine(maxSeq);
        }
    }
}
