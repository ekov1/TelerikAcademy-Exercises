using System;

namespace _03.MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray;
            int N = 0, tempseq = 1, maxseq = 1;

            N = int.Parse(Console.ReadLine());
            intArray = new int[N];

            for (int i = 0; i < N; i++)
                intArray[i] = int.Parse(Console.ReadLine());


            for (int i = 0; i < N - 1; i++)
            {
                if (intArray[i] == intArray[i + 1])
                    tempseq++;
                else
                {
                    if (tempseq > maxseq)
                        maxseq = tempseq;
                    tempseq = 1;
                }
                if (tempseq > maxseq)
                    maxseq = tempseq;


                //Console.WriteLine("maxseq {0}, tempseq {1} ,{2}", maxseq, tempseq, i);
            }
            Console.WriteLine(maxseq);
        }
    }
}