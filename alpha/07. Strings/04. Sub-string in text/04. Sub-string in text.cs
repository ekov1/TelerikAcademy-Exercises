using System;

namespace _04.Sub_string_in_text
{
    class Program
    {
        static void Main(string[] args)
        {
            string text, pattern;
            int counter = 0, index;

            pattern = Console.ReadLine().ToLower();
            text = Console.ReadLine().ToLower();

            index = text.IndexOf(pattern);

            while (index > 0)
            {
                index = text.IndexOf(pattern, index + pattern.Length);
                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
