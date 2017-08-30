using System;
using System.Collections.Generic;
using System.Text;

namespace words
{
    class words
    {
        static Dictionary<char, HashSet<string>> wordsByChar = new Dictionary<char, HashSet<string>>();
        static HashSet<string> allWords = new HashSet<string>();

        static void InitDic()
        {
            for (char a = 'a'; a < 'z'; a++)
            {
                wordsByChar[a] = new HashSet<string>();
            }
        }
        static void AddWord(string word)
        {
            allWords.Add(word);

            for (int i = 0; i < word.Length; i++)
            {
                wordsByChar[word[i]].Add(word);
            }
        }
        static void ReadWords()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string inputLine = Console.ReadLine().ToLower();
                StringBuilder word = new StringBuilder();

                for (int j = 0; j < inputLine.Length; j++)
                {
                    if (inputLine[j] >= 'a' && inputLine[j] <= 'z')
                    {
                        word.Append(inputLine[j]);
                    }
                    else if (word.Length > 0)
                    {
                        AddWord(word.ToString());
                        word.Clear();
                    }
                }

                if (word.Length > 0)
                {
                    AddWord(word.ToString());
                    word.Clear();
                }
            }
        }

        static void ProcessWords()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string word = Console.ReadLine();
                string wordToLower = word.ToLower();

                HashSet<string> current =
                    new HashSet<string>(wordsByChar[wordToLower[0]]);

                for (int j = 1; j < wordToLower.Length; j++)
                {
                    current.IntersectWith(wordsByChar[wordToLower[j]]);
                }

                Console.WriteLine(word + " -> " + current.Count);
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            InitDic();
            ReadWords();

            //foreach (var item in allWords)
            //{
            //    Console.WriteLine(item);
            //}

            ProcessWords();
        }
    }
}
