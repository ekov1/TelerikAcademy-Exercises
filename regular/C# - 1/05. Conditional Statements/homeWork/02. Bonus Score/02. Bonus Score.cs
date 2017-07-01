using System;

namespace _02.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());

            if (score < 1 || score > 9)
            {
                Console.WriteLine("invalid score");
                return;
            }

            if (1 <= score && score <= 3)
                score *= 10;
            else if (4 <= score && score <= 6)
                score *= 100;
            else if (7 <= score && score <= 9)
                score *= 1000;

            Console.WriteLine(score);
        }
    }
}
