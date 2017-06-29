using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Forest_Road
{
    class Forest_Road
    {
        static void Main(string[] args)
        {
            int i,
                n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                string s = new string('.', i) + "*" + new string('.', n-1-i);
                Console.WriteLine(s);
            }

            for (i = n - 2; i >= 0; i--)
            {
                string s = new string('.', i) + "*" + new string('.', n - 1 - i);
                Console.WriteLine(s);
            }
        }
    }
}
