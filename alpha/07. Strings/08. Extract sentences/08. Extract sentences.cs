using System;
using System.Text;

namespace _08.ExtractSentences
{
    class Program
    {
        static void Main(string[] args)
        {//condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/06.%20Strings-and-Text-Processing/homework/08.%20Extract%20sentences/README.md
         //input and values
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string[] sentences = text.Split('.');
            StringBuilder temp = new StringBuilder();
            StringBuilder result = new StringBuilder();

            foreach (var sentence in sentences)
            {
                temp.Clear();
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (char.IsLetter(sentence[i]) == false)
                    {
                        temp.Append(sentence[i]); //parse NON-letter symbols
                    }
                }
                char[] splitChars = temp.ToString().ToCharArray();
                string[] words = sentence.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);

                if (Array.IndexOf(words, word) > -1)
                {
                    result.Append(sentence.Trim());
                    result.Append(". ");
                }
            }
            //print
            Console.WriteLine(result.ToString().Trim());
        }
    }
}