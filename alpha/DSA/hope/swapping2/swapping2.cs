using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapping2
{
    class swapping2
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
            List<int> temp2 = new List<int>();


            for (int i = 0; i < sw.Length; i++)
            {
                int index = seq.IndexOf(sw[i]);

                //for (int j = index + 1; j < seq.Count; j++)
                //{
                //    temp.Add(seq[j]);
                //}
                int count = seq.Count - index;
                temp2 = new List<int>();
                temp2 = seq.GetRange(index+1, count-1);
                temp.AddRange(temp2);
              //  Console.WriteLine(string.Join(" ", temp));

                temp.Add(sw[i]);
              //  Console.WriteLine(string.Join(" ", temp));
                //for (int j = 0; j < index; j++)
                //{
                //    temp.Add(seq[j]);
                //}
                temp2 = new List<int>();
                temp2 = seq.GetRange(0, index);
                temp.AddRange(temp2);
               


                seq = temp;
                temp = new List<int>();

            }
            Console.WriteLine(string.Join(" ", seq));

        }
    }
}