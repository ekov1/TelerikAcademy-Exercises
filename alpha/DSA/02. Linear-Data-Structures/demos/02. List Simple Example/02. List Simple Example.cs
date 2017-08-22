using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.List_Simple_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "C#", "Java" };

            list.Add("SQL");
            list.Add("Python");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
