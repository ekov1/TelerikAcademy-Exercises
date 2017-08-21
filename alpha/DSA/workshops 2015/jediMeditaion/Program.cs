using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jediMeditaion
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var jedis = Console.ReadLine()
                .Split(' ')
                .ToList();

            jedis.Sort(CompareJedis);
            Console.WriteLine(string.Join(" ", jedis));
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
