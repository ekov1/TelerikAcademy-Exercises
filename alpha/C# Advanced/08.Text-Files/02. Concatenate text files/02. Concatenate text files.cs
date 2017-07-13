using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Concatenate_text_files
{
    class Program
    {
        // # Concatenate text files
        // ## Description
        // Write a program that concatenates two text files into another text file.
        static void Main(string[] args)
        {

            string fileOne = @"..\..\..\test1.txt";
            string fileTwo = @"..\..\..\test2.txt";
            string concat = @"..\..\..\concat.txt";

            string fileContents;
            string fileContents2;


            StreamReader streamOne = new StreamReader(fileOne);
            StreamReader streamTwo = new StreamReader(fileTwo);

            using (streamOne)
            {
                fileContents = streamOne.ReadToEnd();
            }

            using (streamTwo)
            {
                fileContents2 = streamTwo.ReadToEnd();
            }

            StreamWriter con = new StreamWriter(concat);

            using (con)
            {
                con.WriteLine(fileContents + fileContents2);
            }

            StreamReader conR = new StreamReader(concat);

            using (conR)
            {
                string filecontents = conR.ReadToEnd();
                Console.WriteLine(filecontents);
            }

        }
    }
}
