using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sorting_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<DateTime>
            {
                new DateTime(2013,4,7),
                new DateTime(2011,5,6),
                new DateTime(2002,1,2),
                new DateTime(1998,6,8)
            };

            list.Sort();
            Console.WriteLine();
            Console.WriteLine("Sorted by year with .Sort(): ");
            Console.WriteLine(string.Join(", ", list));

            Console.WriteLine();
            list.Sort((d1, d2) => -d1.Year.CompareTo(d2.Year));
            Console.WriteLine("Sorted by year desc with .Sort(Comparison<T>):");
            Console.WriteLine(string.Join(", ", list));

            Console.WriteLine();
            Console.WriteLine("Sorted by month with OrderBy(keySelector):");
            Console.WriteLine(string.Join(", ", list.OrderBy(date => date.Month)));

        }
    }
}
