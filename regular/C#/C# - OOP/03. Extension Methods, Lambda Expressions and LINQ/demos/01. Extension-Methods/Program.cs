using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = "one two seven";
            Console.WriteLine(words.WordCount()); // => 3

            var x = new List<int>() { 1, 2, 3 };
            Console.WriteLine(x.ToString<int>());

            x.IncreaseWidth(3);
            Console.WriteLine(x.ToString<int>());
        }
    }
}
