using System;

class Program
{
    static void Main()
    {
        checked
        {
            long s = long.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());

            long[] numbers = new long[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
            }

            int sumCounter = 0;
            int combinations = (int)Math.Pow(2, n);
            for (int i = 1; i < combinations; i++)
            {
                long tempSum = 0;
                for (int j = 0; j < n; j++)
                {
                    int mask = 1 << j;
                    int iAndMask = mask & i;
                    int bit = iAndMask >> j;

                    if (bit == 1)
                    {
                        tempSum += numbers[j];
                    }
                }

                if (tempSum == s)
                {
                    sumCounter += 1;
                }
            }

            Console.WriteLine(sumCounter);
        }
    }
}