using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jedi2
{
    class jedi2
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var jedis = Console.ReadLine()
                .Split(' ')
                .GroupBy(x => x[0])
                //.Aggregate((x, y) =>
                //{
                //    x.ToList().AddRange(y);
                //    return x;
                //})
                .OrderBy(x => x.Key == 'm' ? 0 : (x.Key == 'k' ? 1 : 2))
                .SelectMany(x => x)
                .ToList();

            Console.WriteLine(string.Join(" ", jedis));
        }
    }
}
