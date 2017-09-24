using System;
using System.Collections.Generic;
using System.IO;

namespace _01.Multiverse_Communication
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, digitIn13;
            long decimlaRepresentation = 0, decimalValue = 0;

            var alphabet = new List<string> { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB",
                "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };
            // string alphabetFile = @"alphabet.txt";

            // StreamReader sr = new StreamReader(alphabetFile);

            // using (sr)
            // {
            //     for (int i = 0; i < 13; i++)
            //     {
            //         alphabet.Add(sr.ReadLine());
            //     }
            // }

            // for (int i = 0; i < alphabet.Count; i++)
            // {
            //     Console.WriteLine(alphabet[i]);
            // }

            input = Console.ReadLine();

            for (int i = 0; i < input.Length; i += 3)
            {
                digitIn13 = input.Substring(i, 3);
                decimalValue = alphabet.IndexOf(digitIn13);

                decimlaRepresentation *= 13;
                decimlaRepresentation += decimalValue;
            }

            Console.WriteLine(decimlaRepresentation);
        }
    }
}
