using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Compare_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string arr1 = "", arr2 = "";

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                arr1 += Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                arr2 += Console.ReadLine();
            }

            string result = "";

            if (arr1 == arr2) result = "Equal";
            else result = "Not equal";

            Console.WriteLine(result);
        }
    }
}
