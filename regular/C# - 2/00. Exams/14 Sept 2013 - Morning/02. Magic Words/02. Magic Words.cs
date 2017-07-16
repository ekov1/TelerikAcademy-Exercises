using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Magic_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, newIndex,
                maxLength = 0;

            List<string> words = new List<string>();
            StringBuilder result;

            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                words.Add(Console.ReadLine());
            }

            // Reorder
            for (int i = 0; i < n; i++)
            {
                var word = words[i];
                newIndex = word.Length % (n + 1);

                words[i] = null;
                words.Insert(newIndex, word);
                words.Remove(null);

                //if (newIndex < i)
                //    words.RemoveAt(i + 1);
                //else
                //    words.RemoveAt(i);
            }

            // Print
            result = new StringBuilder();

            // foreach (var word in words)
            //     maxLength = Math.Max(maxLength, wr.Length);
            maxLength = words.Max(word => word.Length);

            for (int i = 0; i < maxLength; i++)
            {
                foreach (var word in words)
                {
                    if (word.Length > i)
                        result.Append(word[i]);
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
