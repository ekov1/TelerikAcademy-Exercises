using System;

namespace _02.Miss_Cat_2011
{
    class Miss_Cat_2011
    {
        static void Main(string[] args)
        {
            int i;
            int[] cats = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            // count votes
            int n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                int vote = int.Parse(Console.ReadLine());

                cats[vote - 1]++;
            }

            //define winner
            int maxVotes = 0, winner = 0;

            for (i = 0; i < cats.Length; i++)
            {
                if (maxVotes < cats[i])
                {
                    maxVotes = cats[i];
                    winner = i + 1;
                }
            }
            Console.WriteLine(winner);
        }
    }
}
