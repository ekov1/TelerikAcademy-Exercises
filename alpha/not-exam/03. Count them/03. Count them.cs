using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Count_them
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string input = "", temp = "";
            List<string> variables = new List<string>();
            Regex reg = new Regex("^[a-zA-Z0-9]+$");

            while (input != "{!}")
            {
                input = Console.ReadLine();

                if (!input.Contains("//") && !input.Contains("/*") && !input.Contains("*/"))
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == '@')
                        {
                            while (input[i] != ' ' || input[i] != '\'' || input[i] != ';' || input[i] != '[')
                            {
                                temp += input[i];
                                i++;
                            }
                            temp = temp.Substring(1);
                            variables[counter] = temp;
                            counter++;
                            temp = "";
                        }
                    }
                }
            }

            foreach (var v in variables)
            {
                Console.WriteLine(v);
            }
        }
    }
}
