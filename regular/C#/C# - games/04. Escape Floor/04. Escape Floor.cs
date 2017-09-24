namespace _04.Escape_Floor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Escape_Floor
    {
        public const int PLAYFIELD_HEIGHT = 30;
        public const int PLAYFIELD_WIDTH = 30;
        public const int SCORE_WITH_ADD = 15;

        // Floor var
        public static int holeWidth = 10;

        public static Random rng = new Random();
        public static bool isGameOver = false;
        public static int[,] playfield = new int[PLAYFIELD_HEIGHT, PLAYFIELD_WIDTH];

        static void Main(string[] args)
        {
            Console.BufferHeight = Console.WindowHeight = PLAYFIELD_HEIGHT;
            Console.BufferWidth = Console.WindowWidth = PLAYFIELD_WIDTH;
            Console.CursorVisible = false;

            // Draw the Player
            // Move the player
            //      - horizontal
            //      - vertical
            // Initialize the player

            // Floor Generation
            // Floor Drawing
            // Floos moving up

            // Draw UI
            // Difficulties
            // Points

            // Power-Ups
            // Game Over
            while (!isGameOver)
            {
                MoveFloorsUp();
                GenerateFloors();
            }
        }

        private static void MoveFloorsUp()
        {
            for (int i = 0; i < PLAYFIELD_HEIGHT; i++)
            {
                for (int j = 0; j < PLAYFIELD_WIDTH; j++)
                {
                    playfield[i, j] = 0;
                    playfield[i-1, j] = 1;
                }
            }
        }

        private static void GenerateFloors()
        {
            int startingPosition = rng.Next(0, PLAYFIELD_WIDTH - holeWidth);
            int startingRow = PLAYFIELD_HEIGHT - 1;

            for (int i = 0; i < PLAYFIELD_WIDTH; i++)
            {
                playfield[startingRow, i] = 1;
            }

            for (int i = startingPosition; i <= startingPosition + holeWidth; i++)
            {
                playfield[startingRow, i] = 0;
            }
        }
    }
}
