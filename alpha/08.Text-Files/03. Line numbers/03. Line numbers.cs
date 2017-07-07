using System.IO;

namespace _03.Line_numbers
{
    class Program
    {
        // # Line numbers
        // ## Description
        // Write a program that reads a text file and inserts line numbers in front of each of its lines.
        // The result should be written to another text file.

        static void Main(string[] args)
        {
            string inputFileName = @"..\..\input.txt";
            string outputFileName = @"..\..\output.txt";

            StreamReader reader = new StreamReader(inputFileName);
            StreamWriter writer = new StreamWriter(outputFileName);

            using (writer)
            {
                using (reader)
                {
                    int lineNumber = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.Write(lineNumber + " ");
                        writer.WriteLine(line);

                        line = reader.ReadLine();
                        lineNumber++;
                    }
                }
            }
        }
    }
}
