using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Spell_caster
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            int big = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (big < words[i].Length)
                {
                    big = words[i].Length;
                }
            }

            string spell = "";

            for (int j = 0; j < big; j++)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length != 0)
                    {
                        string letter = words[i].Substring(words[i].Length - 1);
                        //Console.WriteLine(letter);
                        spell += letter;
                        words[i] = words[i].Substring(0, words[i].Length - 1);
                        //Console.WriteLine(words[i]);
                    }
                }
            }

            //Console.WriteLine(spell);
            char[] letters = spell.ToCharArray();
            char[] answer = new char[letters.Length];

            for (int i = 0; i < letters.Length; i++)
            {
                int n = letters[i] - 'a' + 1;

                if (i + n > letters.Length)
                {
                    n = n - (letters.Length - i);
                    while (n > letters.Length)
                    {
                        n -= letters.Length;
                    }
                }
                else
                {
                    n = i + n;
                }

                letters[n] = letters[i];
            }

            for (int j = 0; j < letters.Length; j++)
            {
                Console.Write(letters[j]);
            }
        }

       
    }
}
