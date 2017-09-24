using System;

namespace _03.Play_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            string input = Console.ReadLine().ToUpper();

            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] == input)
                {
                    Console.WriteLine("yes {0}", input);
                    return;
                }
            }

            Console.WriteLine("no {0}", input);
        }
    }
}
