using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Characters
{
    class Characters
    {
        static void Main(string[] args)
        {
            char symbol = 'a';
            Console.WriteLine(" the code of sybol {0} is {1}", symbol, (int)symbol);

            char aLatin = 'A';
            char аКирилично = 'А';
            Console.WriteLine(" the code of the aLatin sybol {0} while аКирилично {1}", (int)aLatin, (int)аКирилично);
        }
    }
}
