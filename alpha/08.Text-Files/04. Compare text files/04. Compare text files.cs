using System;
using System.IO;

namespace _04.Compare_text_files
{
    class Program
    {
        // # Compare text files

        // ## Description
        // Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
        // Assume the files have equal number of lines.

        static void Main(string[] args)
        {
            int countSame = 0, countDiff = 0;
            string lineOne, lineTwo;

            string inputFileName = @"..\..\input.txt";
            string outputFileName = @"..\..\output.txt";

            StreamReader readerOne = new StreamReader(inputFileName);
            StreamReader readerTwo = new StreamReader(outputFileName);

            using (readerOne)
            {
                using (readerTwo)
                {
                    lineOne = readerOne.ReadLine();
                    lineTwo = readerTwo.ReadLine();

                    while (lineOne != null)
                    {
                        lineOne = readerOne.ReadLine();
                        lineTwo = readerTwo.ReadLine();

                        if (lineOne == lineTwo) countSame++;
                        else countDiff++;
                    }
                }
            }

            Console.WriteLine("same = {0}",countSame);
            Console.WriteLine("diff = {0}", countDiff);

        }
    }
}
