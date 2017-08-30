using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

namespace Player_ranking
{
    class rankList
    {
        public static void Run()
        {
            BigList<Player> playerRanklist = new BigList<Player>();
            Dictionary<plType, OrderedSet<Player>> typeplayerMap = new Dictionary<plType, OrderedSet<Player>>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandparams = command.Split();
                switch (commandparams[0])
                {
                    case "add":
                        plType type = (plType)Enum.Parse(typeof(plType), commandparams[2]);
                        int age = int.Parse(commandparams[3]);

                        Player player = new Player();
                        player.Age = age;

                        typeplayerMap[type].Add(player);
                        playerRanklist.Insert(position, player);

                        Console.WriteLine($"");
                        break;

                    case "Find":
                        string findType = (plType)Enum.Parse(typeof(plType), commandparams[1]);
                        var players = typeplayerMap[findType];

                        string result = $"Type: {findType}: {players.Take(5).Select(p => p.ToString() + "; ")}";
                        Console.WriteLine();
                        break;

                    case "ranklist":
                        int start = int.Parse(commandparams[1]) - 1;
                        int end = int.Parse(commandparams[2]) - 1;
                        int count = end - start + 1;
                        var rankedListPlayers = ;
                        int playerPosition = start + 1;
                        break;
                }
            }
        }
    }

    public enum plType
    {
        Agressive,
        Neutral,
        Defensive
    }

    public class Player : IComparable<Player>
    {
        public string Name { get; set; }

        public plType Type { get; set; }

        public int Age { get; set; }

        public int CompareTo(Player other)
        {
            int result = this.Name.CompareTo(other.Name);

            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age) * -1;
                // result = other.Age.CompareTo(this.Age);
            }

            return result;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}
