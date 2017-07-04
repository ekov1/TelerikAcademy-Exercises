using System;

namespace _03.Correct_brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, result = "";
            int bracketsLeft = 0, bracketsRight = 0;

            input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(') bracketsLeft++;
                else if (input[i] == ')') bracketsRight++;
            }

            if (bracketsLeft == bracketsRight) result = "Correct";
            else result = "Incorrect";

            Console.WriteLine(result);
        }
    }
}
