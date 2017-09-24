using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Logical_Operators
{
    class Logical_Operators
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            Console.WriteLine();
            Console.WriteLine(" {0} && {1} => {2} \n", a, b, (a && b)); // False
            Console.WriteLine(" {0} || {1} => {2} \n", a, b, (a || b)); // True
            Console.WriteLine(" {0} ^ {1} => {2} \n", a, b, (a ^ b)); // True
            Console.WriteLine(" !false => {0} \n", !b); // True
            Console.WriteLine(" {0} || {1} => {2} \n", true, b, (b || true)); // True
            Console.WriteLine(" {0} && {1} => {2} \n", true, b, (b && true)); // False
            Console.WriteLine(" {0} || {1} => {2} \n", true, a, (a || true)); // True
            Console.WriteLine(" {0} && {1} => {2} \n", true, a, (a && true)); // True
            Console.WriteLine(" !true => {0} \n", !a); // False
            Console.WriteLine(" ((5 > 7) ^ (a == b)) => {0} \n", ((5 > 7) ^ (a == b))); // False
        }
    }
}
