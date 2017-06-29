using System;
using System.Diagnostics;
using System.Threading;

namespace _03.Falling_Rocks
{
    class Program
    {
        static void Main(string[] args)
        {
            //  1.) General Initialization
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;

            Random rng = new Random();
            int[,] rockPositions = new int[30, 45];

            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;
            // TODO: Bug Detection Try 45
            int playField = 40;
            var score = Stopwatch.StartNew();
            int lives = 5;

            //  2.) Dwarf initialization
            int dwarfX = playField / 2;
            int dwarfY = Console.WindowHeight - 1;
            string dwarfSyblol = "-^-";
            ConsoleColor dwarfColor = ConsoleColor.Green;

            bool isGameOver = false;
            //  3.) Game Loop
            while (!isGameOver)
            {
                Console.Clear();

                //  4.) Key handler
                dwarfX = KeyHandler(playField, dwarfX);

                //  5.) Create Rocks
                CreateRocks(rng, rockPositions, playField);

                //  6.) Drop Rocks
                DropRocks(rockPositions, playField);

                //  7.) Collision Check
                bool isThereCollision = CollisionCeck(rockPositions, playField, ref lives, dwarfX);

                //  8.) Print Dwarf
                PrintDwarf(dwarfX, dwarfY, dwarfSyblol, dwarfColor);

                //  9.) Print Rocks
                PrintRocks(rockPositions, playField);

                // 10.) Clear last row
                CleanLastRow(rockPositions, playField);

                // 11.) Draw Vertical lines
                DrawVerticallines(playField);

                // 12.) Draw Score
                ScoreContol(playField, score, lives);

                // 14.) Game Over logic
                if (isThereCollision)
                {
                    break;
                }
            }
            Console.SetCursorPosition(15, 20);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game Over! \n");
        }

        private static void ScoreContol(int playField, Stopwatch score, int lives)
        {
            long scorePoints = score.ElapsedMilliseconds / 100;
            Console.SetCursorPosition(playField + 5, 2);
            Console.WriteLine("SCORE: {0}", scorePoints);

            Console.SetCursorPosition(playField + 5, 5);
            Console.WriteLine("LIVES: {0}", lives);

            // 13.) Set difficulty
            int easy = 250, normal = 200, hard = 150, insane = 80;
            string difficultyName = "easy";

            Console.ForegroundColor = ConsoleColor.Green;
            int difficulty = easy;

            if (score.ElapsedMilliseconds > 20000)
            {
                difficulty = normal;
                difficultyName = "Normal";
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            if (score.ElapsedMilliseconds > 40000)
            {
                difficulty = hard;
                difficultyName = "HARD";
                Console.ForegroundColor = ConsoleColor.Red;
            }

            if (score.ElapsedMilliseconds > 60000)
            {
                difficulty = insane;
                difficultyName = "INSANE!!!";
                Console.ForegroundColor = ConsoleColor.Magenta;
            }

            Console.SetCursorPosition(playField + 2, 9);
            Console.WriteLine("Difficulty: {0}", difficultyName);

            Thread.Sleep(difficulty);
        }

        private static void DrawVerticallines(int playField)
        {
            for (int row = 0; row < Console.BufferHeight; row++)
            {
                Console.SetCursorPosition(playField, row);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|");
            }
        }

        private static void CleanLastRow(int[,] rockPositions, int playField)
        {
            for (int col = 0; col < playField - 1; col++)
            {
                rockPositions[29, col] = 0;
            }
        }

        private static void PrintRocks(int[,] rockPositions, int playField)
        {
            //char rockSymbol = RandomRockSymbol(rng);
            char rockSymbol = 'O';

            for (int row = 0; row < 30; row++)
            {
                for (int col = 0; col < playField; col++)
                {
                    if (rockPositions[row, col] == 1)
                    {
                        // check with col,row
                        Console.SetCursorPosition(col, row);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        //Console.ForegroundColor = RandomColorGenerator(rng);
                        Console.Write(rockSymbol);
                        //Console.WriteLine("{0}",RandomRockSymbol(rng));
                    }
                }
            }
        }

        private static void PrintDwarf(int dwarfX, int dwarfY, string dwarfSyblol, ConsoleColor dwarfColor)
        {
            Console.SetCursorPosition(dwarfX, dwarfY);
            Console.ForegroundColor = dwarfColor;
            Console.Write(dwarfSyblol);
        }

        private static bool CollisionCeck(int[,] rockPositions, int playField, ref int lives, int dwarfX)
        {
            bool isThereCollision;

            for (int col = 0; col < playField; col++)
            {
                // dwarf symbol is (0) so we need to check 3 positions
                bool hasDwarfBeenHit = (dwarfX == col || dwarfX + 1 == col || dwarfX + 2 == col);
                if (rockPositions[29, col] == 1 && hasDwarfBeenHit)
                {
                    lives--;
                }
            }

            if (lives > 0) isThereCollision = false;
            else isThereCollision = true;
            return isThereCollision;
        }

        private static void DropRocks(int[,] rockPositions, int playField)
        {
            // check every cell, if it is 1, move down, delete previous
            for (int row = 29; row >= 0; row--)
            {
                for (int col = 0; col < playField; col++)
                {
                    if (rockPositions[row, col] == 1)
                    {
                        rockPositions[row, col] = 0;
                        if (row != 29)
                            rockPositions[row + 1, col] = 1;
                    }
                }
            }
        }

        private static void CreateRocks(Random rng, int[,] rockPositions, int playField)
        {
            int numberOfRocks = rng.Next(1, 3);
            for (int i = 0; i < numberOfRocks; i++)
            {
                int rockLength = rng.Next(1, 3);
                int postionRockX = rng.Next(0, playField);

                for (int j = 0; j < rockLength; j++)
                {
                    rockPositions[0, postionRockX + j] = 1;
                }
            }
        }

        private static int KeyHandler(int playField, int dwarfX)
        {
            if (Console.KeyAvailable == true)
            {
                // hack for better controls
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey(true);

                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    // check if out of box
                    if (dwarfX - 1 >= 0)
                    {
                        dwarfX -= 2;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    // check if out of box
                    if (dwarfX + 1 < playField)
                    {
                        dwarfX += 2;
                    }
                }
            }

            return dwarfX;
        }

        private static ConsoleColor RandomColorGenerator(Random rng)
        {
            ConsoleColor[] colors = {ConsoleColor.Blue, ConsoleColor.Yellow, ConsoleColor .Magenta,
            ConsoleColor.White,ConsoleColor.Green,ConsoleColor.Gray};
            int randomColornumber = rng.Next(0, colors.Length);

            return colors[randomColornumber];
        }

        private static char RandomRockSymbol(Random rng)
        {
            char[] rockSymbols = { '@', '#', '$', '%' };
            int randomRockSymbolNumber = rng.Next(0, rockSymbols.Length);

            return rockSymbols[randomRockSymbolNumber];
        }
    }
}
