using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    /// <summary>
    ///  We are given the following sequence:
    ///   - `S1 = N;`
    ///   - `S2 = S1 + 1;`
    ///   - `S3 = 2* S1 + 1;`
    ///   - `S4 = S1 + 2;`
    ///   - `S5 = S2 + 1;`
    ///   - `S6 = 2* S2 + 1;`
    ///   - `S7 = S2 + 2;`
    ///   - ...
    ///   - Using the `Queue<T>` class write a program to print its first 50 members for given N.
    ///   - Example: `N= 2` &rarr; `2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...`
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int> q = new Queue<int>();
            List<int> seq = new List<int>();

            q.Enqueue(n);
            seq.Add(n);

            while (seq.Count < 50)
            {
                int x = q.Dequeue();

                int x1 = x + 1;
                q.Enqueue(x1);
                seq.Add(x1);

                int x2 = (2 * x) + 1;
                q.Enqueue(x2);
                seq.Add(x2);

                int x3 = x + 2;
                q.Enqueue(x3);
                seq.Add(x3);
            }

            foreach (var x in seq)
            {
                Console.Write(x + " ");
            }
        }
    }
}
