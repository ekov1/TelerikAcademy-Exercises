using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guards
{
    class Guards
    {
        public const int INFINITY = int.MaxValue;

        static void Main(string[] args)
        {
            int[] mazeDimensions = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int[,] maze = new int[mazeDimensions[0], mazeDimensions[1]];

            int numberOfGuards = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfGuards; i++)
            {
                string[] guardsPositions = Console.ReadLine().Split(' ').ToArray();
                int guardRow = int.Parse(guardsPositions[0]);
                int guardCol = int.Parse(guardsPositions[1]);
                string guardDirection = guardsPositions[2];
            }

            switch (guardDirection)
            {
                case "U":

                    break;
                case "D":
                    break;
                case "L":
                    break;
                case "R":
                    break;
            }
        }
    }
}
