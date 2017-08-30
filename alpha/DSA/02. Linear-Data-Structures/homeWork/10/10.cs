using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    /// <summary>
    ///  We are given numbers N and M and the following operations:
    ///  * `N = N+1`
    ///  * `N = N+2`
    ///  * `N = N*2`
    /// 
    ///  - Write a program that finds the shortest sequence of operations
    ///  from the list above that starts from `N` and finishes in `M`.
    ///  - _Hint_: use a queue.
    ///  - Example: `N = 5`, `M = 16`
    ///  - Sequence: 5 ->; 7 ->; 8 ->; 16 / 3 operations
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int counter = 0;

            while (m > n)
            {
                if (m / 2 >= n)
                {
                    m /= 2;
                }
                else if (m - 2 >= n)
                {
                    m -= 2;
                }
                else
                {
                    m -= 1;
                }
                counter++;
            }

            Console.WriteLine(counter + " operations");

        }
    }
}
