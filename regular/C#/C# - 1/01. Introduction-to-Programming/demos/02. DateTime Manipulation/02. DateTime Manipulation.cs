using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DateTime_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime yesterday = new DateTime(2017, 5, 30);

            Console.WriteLine("now is: " + now);
            Console.WriteLine("yesterday was: " + yesterday);

            Console.WriteLine();
            //CompareTo returns -1 if now < yesterday, 0 if now = yesterday, 1 if now > yesterday
            Console.WriteLine(now.CompareTo(yesterday));
            Console.WriteLine(now - yesterday);
        }
    }
}
