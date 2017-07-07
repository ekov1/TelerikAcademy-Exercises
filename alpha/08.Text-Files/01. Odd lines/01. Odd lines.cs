using System;
using System.IO;
using System.Text;

namespace _01.Odd_lines
{
    class Program
    {
        //# Odd lines

        //## Description
        // Write a program that reads a text file and prints on the console its odd lines.

        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;

            string fileName = @"..\..\..\Tarzan-of-the-Apes.txt";
            //Console.WriteLine("The contents of the file {0} is:", fileName);

            StreamReader streamReader = new StreamReader(fileName);

            //using (streamReader)
            //{
            //    string fileContents = streamReader.ReadToEnd();
            //    Console.WriteLine(fileContents);
            //}

            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;

                    if (lineNumber % 2 != 0)
                        Console.WriteLine("Line {0}: {1}", lineNumber, line);

                    line = reader.ReadLine();
                }
            }
        }
    }
}
