using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Float_or_Double
{
    class Float_or_Double
    {
        static void Main(string[] args)
        {
            /*
            Which of the following values can be assigned to a variable of type float and which to a variable of type 
            double: 34.567839023, 12.345, 8923.1234857, 3456.091? 
            Write a program to assign the numbers in variables and print them to ensure no precision is lost.
            */

            float aF = 12.345f;
            double aD = 12.345d;
            Console.WriteLine("aF 12.345 - {0}",aF);
            Console.WriteLine("dD 12.345 - {0}", aD);

            Console.WriteLine();

            float bF = 34.567839023f;
            double bD = 34.567839023d;
            Console.WriteLine("bF 34.567839023 - {0}", bF);
            Console.WriteLine("bD 34.567839023 - {0}", bD);

            Console.WriteLine();

            float cF = 3456.091f;
            double cD = 3456.091d;
            Console.WriteLine("cF 3456.091 - {0}", cF);
            Console.WriteLine("cD 3456.091 - {0}", cD);

            Console.WriteLine();

            float dF = 8923.1234857f;
            double dD = 8923.1234857d;
            Console.WriteLine("dF 8923.1234857 - {0}", dF);
            Console.WriteLine("dD 8923.1234857 - {0}", dD);
        }
    }
}
