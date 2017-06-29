using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Isosceles_Triangle
{
    class Isosceles_Triangle
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            string s = @"
   ©
   
  © ©
  
 ©   ©
 
© © © ©
";
            Console.WriteLine(s);
            char x = '\u00A9';
            Console.WriteLine(x);
        }
    }
}
