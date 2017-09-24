using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Decode_and_Decrypt
{
    class Program
    {
        // Encrypt("ABCDE", "PQR") = "PRTMU" and Encrypt("PRTMU", "PQR") = "ABCDE"

        // Encode(Encrypt(message, cypher) + cypher) + lengthOfCypher

        // If the cypher string is shorter than the message, using it symbols loops 
        // to the beginning of the cypher.E.g. for a message "ABCDE" and a cypher "PQR" 
        // we will have:
        // 'A' encrypted with 'P' = 'P', 'B' encrypted with 'Q' = 'R', 'C' encrypted with 'R' = 'T', 'D'
        // encrypted with 'P' = 'M', 'E' encrypted with 'Q' = 'U'

        // If the message string is shorter than the cypher, some of its symbols will be encoded several
        // times, until all of the cypher symbols are used.
        // E.g. for a message "ABC" and a cypher "PQRST", we will have:
        // 'A' encrypted with 'P' and the result ('P') encrypted with 'S' = '^' (ASCII 94), 
        // 'B' encrypted with 'Q' and the result('R') encrypted with 'T' = 'C',
        // 'C' encrypted only with 'R' =  'T'

        static void Main(string[] args)
        {
            string input, temp = "",
                encodedMessage, decodedMessage,
                encryptedMessage, cypher, message;
            int lengthOfCyper = 0;

            input = Console.ReadLine();

            //01. Encode(Encrypt(message, cypher) + cypher) + lengthOfCyper
            var digits = new List<int>();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                //Console.WriteLine();
                //Console.Write(input[i]);
                //Console.WriteLine();
                if (char.IsDigit(input[i]))
                    digits.Add(int.Parse(input[i] + ""));
                else
                    break;
            }

            digits.Reverse();
            foreach (var dg in digits)
            {
                // Console.Write(dg);
                temp += dg;
            }

            lengthOfCyper = int.Parse(temp);
            // Console.WriteLine(lengthOfCyper);

            //02. Encode(Encrypt(message, cypher) + cypher)
            encodedMessage = input.Substring(0, input.Length - digits.Count);
            // Console.WriteLine(encodedMessage);

            decodedMessage = Decode(encodedMessage);
            // test 
            // Console.WriteLine(Decode("ABBAA6BA") == "ABBAABBBBBBA");
            // Console.WriteLine(Decode("ABBAABA") == "ABBAABA");

            encryptedMessage = decodedMessage.Substring(0, decodedMessage.Length - lengthOfCyper);
            cypher = decodedMessage.Substring(decodedMessage.Length - lengthOfCyper);

            // Console.WriteLine(encryptedMessage);
            // Console.WriteLine(cypher);
            message = Encrypt(encryptedMessage, cypher);
        }

        private static string Encrypt(string encryptedMessage, string cypher)
        {
            int messageIndex, cypherIndex,
                steps = Math.Max(encryptedMessage.Length, cypher.Length);

            for (int i = 0; i < steps; i++)
            {
                messageIndex = steps % encryptedMessage.Length;
                cypherIndex = steps % cypher.Length;


            }

            return "";
        }

        private static string Decode(string encodedMessage)
        {
            // ABBAA61BA => ABBAABBBBBBA
            StringBuilder result = new StringBuilder();
            int count = 0;

            foreach (var ch in encodedMessage)
            {
                if (char.IsDigit(ch))
                {
                    count *= 10;
                    count += int.Parse(ch.ToString()); //ch - '0';
                }
                else
                {
                    if (count == 0)
                        result.Append(ch);
                    else
                    {
                        result.Append(ch, count);
                        count = 0;
                    }

                }
            }

            return result.ToString();
        }
    }
}
