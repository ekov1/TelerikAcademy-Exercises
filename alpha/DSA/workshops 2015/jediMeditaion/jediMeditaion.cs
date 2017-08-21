using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jediMeditaion
{
    class jediMeditaion
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var jedis = Console.ReadLine()
                .Split(' ')
                .ToList();

            // unstable
            // jedis.Sort(CompareJedis);
            // Console.WriteLine(string.Join(" ", jedis));

            var mList = new List<string>();
            var kList = new List<string>();
            var pList = new List<string>();

            foreach (var jedi in jedis)
            {
                if (jedi[0] == 'm')
                {
                    mList.Add(jedi);
                }
                if (jedi[0] == 'k')
                {
                    kList.Add(jedi);
                }
                if (jedi[0] == 'p')
                {
                    pList.Add(jedi);
                }
            }

            if (kList.Count > 0)
                mList.AddRange(kList);
            if (pList.Count > 0)
                mList.AddRange(pList);

            Console.WriteLine(string.Join(" ", mList));
        }

        public static int CompareJedis(string x, string y)
        {
            if (x[0] == 'm')
            {
                return -1;
            }
            if (y[0] == 'm')
            {
                return 1;
            }
            if (x[0] == 'k')
            {
                return -1;
            }
            if (y[0] == 'k')
            {
                return 1;
            }
            return 2;
        }
    }
}
