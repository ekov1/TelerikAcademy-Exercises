using System;
using System.Collections.Generic;
using System.Linq;

namespace swapping
{
    class swapping
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] sw = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> seq = new List<int>();

            for (int i = 1; i < n + 1; i++)
            {
                seq.Add(i);
            }

            List<int> temp = new List<int>();
          

            for (int i = 0; i < sw.Length; i++)
            {
                int index = seq.IndexOf(sw[i]);
                for (int j = index + 1; j < seq.Count; j++)
                {
                    temp.Add(seq[j]);
                }

                temp.Add(sw[i]);

                for (int j = 0; j < index; j++)
                {
                    temp.Add(seq[j]);
                }

                seq = temp;
                temp = new List<int>();

            }

            Console.WriteLine(string.Join(" ", seq));
        }
    }
}
