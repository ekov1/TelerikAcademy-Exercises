﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Format_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Reformat the following C# code to make it readable according to the C# best practices for code 
            formatting. Change the casing of the identifiers in the code (e.g. use PascalCase for the 
            class name): HorribleCode.cs
            */

            Console.WriteLine("Hi, I am horribly formatted program");

            Console.WriteLine("Numbers and squares:");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + " --> " + i * i);
            }
        }
    }
}
