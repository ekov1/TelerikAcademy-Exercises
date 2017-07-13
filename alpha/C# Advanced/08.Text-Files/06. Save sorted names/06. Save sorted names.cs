using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Save_sorted_names
{
    // # Save sorted names

    // ## Description
    // Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

    // _Example:_

    //|  input.txt                          | output.txt |
    //|:----------:                         |:----------:|
    //| Ivan<br> Peter<br> Maria<br> George | George<br> Ivan <br> Maria<br> Peter |
    class Program
    {
        static void Main(string[] args)
        {

            string inputFileName = @"..\..\input.txt";
            string outputFileName = @"..\..\output.txt";

            StreamReader readerOne = new StreamReader(inputFileName);

        }
    }
}
