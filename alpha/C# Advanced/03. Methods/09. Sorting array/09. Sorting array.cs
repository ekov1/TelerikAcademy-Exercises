using System;

namespace _09.Sorting_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string n, array;
            n = Console.ReadLine();
            array = Console.ReadLine();
            sort(n, array);
        }
        static void sort(string n, string array)
        {
            int N, i, j, temp;
            N = int.Parse(n);

            char[] delimiterChars = { ' ' };
            string[] AR = array.Split(delimiterChars);
            int[] sort = new int[N];

            for (i = 0; i < N; i++)
            {
                sort[i] = int.Parse(AR[i]);
            }

            for (i = 0; i < N; i++)
            {
                for (j = i + 1; j < N; j++)
                {
                    if (sort[i] < sort[j])
                    {
                        temp = sort[i];
                        sort[i] = sort[j];
                        sort[j] = temp;
                    }
                }
            }
            for (i = N - 1; i >= 0; i--)
            {
                if (i == N - 1)
                    Console.Write(sort[i]);
                else
                    Console.Write(" " + sort[i]);
            }
        }
    }
}