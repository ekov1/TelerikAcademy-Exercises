using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _01.Snake
{
    class Program
    {
        struct Position
        {
            public int row; // x
            public int col; // y
            public Position(int row, int col)
            {
                this.row = row;
                this.col = col;
            }
        }
        static void Main(string[] args)
        {
            // console buffer setup
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;

            // snake generation
            Queue<Position> snakeElements = new Queue<Position>();

            //Position pos1 = new Position();
            //pos1.X = 0;
            //pos1.Y = 0;
            //snakeElements.Enqueue(pos1);

            //Position pos1 = new Position(0,0);
            //snakeElements.Enqueue(new Position(0, 0));
            //snakeElements.Enqueue(new Position(0, 1));
            //snakeElements.Enqueue(new Position(0, 2));
            //snakeElements.Enqueue(new Position(0, 3));
            //snakeElements.Enqueue(new Position(0, 4));
            //snakeElements.Enqueue(new Position(0, 5));

            for (int i = 0; i < 6; i++)
            {
                snakeElements.Enqueue(new Position(0, i));
            }

            // draw Snake
            foreach (Position position in snakeElements)
            {
                Console.SetCursorPosition(position.col, position.row);
                Console.WriteLine("*");
            }

            // speed
            int speed = 100;

            // score 
            int score = 0;

            // food generation
            Random randomNumberGenerator = new Random();
            Position food = new Position(randomNumberGenerator.Next(0, Console.WindowHeight),
                randomNumberGenerator.Next(0, Console.WindowWidth));
            Console.SetCursorPosition(food.col, food.row);
            Console.WriteLine("@");

            int foodGenerationMoment = Environment.TickCount;
            int foodDisappearTime = 8000;

            // directions control

            byte right = 0,
                  left = 1,
                  down = 2,
                    up = 3;

            Position[] directions = new Position[]
            {
                new Position(0, 1), // right 0
                new Position(0,-1), // left  1
                new Position(1, 0), // down  2
                new Position(-1,0)  // up    3
            };

            int direction = right;

            // game loop
            while (true)
            {
                // direction conditions
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();

                    if (userInput.Key == ConsoleKey.RightArrow)
                        if (direction != left) direction = right;

                    if (userInput.Key == ConsoleKey.LeftArrow)
                        if (direction != right) direction = left;

                    if (userInput.Key == ConsoleKey.DownArrow)
                        if (direction != up) direction = down;

                    if (userInput.Key == ConsoleKey.UpArrow)
                        if (direction != down) direction = up;
                }

                // collision with food
                Position snakeHeadCurrentPosition = snakeElements.Last();

                if (snakeHeadCurrentPosition.row == food.row && snakeHeadCurrentPosition.col == food.col)
                {
                    score += 1;
                    speed -= 3;

                    do
                    {
                        food = new Position(randomNumberGenerator.Next(1, Console.WindowHeight - 1),
                                randomNumberGenerator.Next(1, Console.WindowWidth - 1));
                    }
                    while (snakeElements.Contains(food));

                    Console.SetCursorPosition(food.col, food.row);
                    Console.WriteLine("@");

                    foodGenerationMoment = Environment.TickCount;
                }
                else if (Environment.TickCount - foodGenerationMoment >= foodDisappearTime)
                {
                    Console.SetCursorPosition(food.col, food.row);
                    Console.WriteLine(" ");

                    do
                    {
                        food = new Position(randomNumberGenerator.Next(1, Console.WindowHeight - 1),
                                randomNumberGenerator.Next(1, Console.WindowWidth - 1));
                    }
                    while (snakeElements.Contains(food));
                    Console.SetCursorPosition(food.col, food.row);
                    Console.WriteLine("@");

                    foodGenerationMoment = Environment.TickCount;
                }
                else
                {
                    Position endOfTail = snakeElements.Dequeue();
                    Console.SetCursorPosition(endOfTail.col, endOfTail.row);
                    Console.WriteLine(" ");
                }

                // determine next position
                Position snakeHead = snakeElements.Last();
                Position snakEndOfTail = snakeElements.First();

                Position nextDirection = directions[direction];

                Position snakeNewHeadPosition =
                    new Position(snakeHead.row + nextDirection.row, snakeHead.col + nextDirection.col);


                //if (snakeNewHeadPosition.row < 0 || Console.WindowWidth <= snakeNewHeadPosition.col
                //    || snakeNewHeadPosition.col < 0 || Console.WindowHeight <= snakeNewHeadPosition.row
                //    || snakeElements.Contains(snakeNewHeadPosition))
                if (snakeElements.Contains(snakeNewHeadPosition))
                {
                    break; // Game Over
                }
                else
                {
                    if (snakeNewHeadPosition.row < 0) snakeNewHeadPosition.row = Console.WindowHeight - 1;
                    if (snakeNewHeadPosition.col < 0) snakeNewHeadPosition.col = Console.WindowWidth - 1;
                    if (snakeNewHeadPosition.row > Console.WindowHeight - 1) snakeNewHeadPosition.row = 0;
                    if (snakeNewHeadPosition.col > Console.WindowWidth - 1) snakeNewHeadPosition.col = 0;

                   
                    Console.SetCursorPosition(snakeHead.col, snakeHead.row);
                    Console.WriteLine("*");

                    snakeElements.Enqueue(snakeNewHeadPosition);

                    Console.SetCursorPosition(snakeNewHeadPosition.col, snakeNewHeadPosition.row);
                    if (direction == right) Console.WriteLine(">");
                    if (direction == right) Console.WriteLine("<");
                    if (direction == right) Console.WriteLine("^");
                    if (direction == right) Console.WriteLine("v");
                }


                //// draw Snake
                //Console.Clear();

                //foreach (Position position in snakeElements)
                //{
                //    Console.SetCursorPosition(position.col, position.row);
                //    Console.WriteLine("*");
                //}

                //// draw food
                //Console.SetCursorPosition(food.col, food.row);
                //Console.WriteLine("@");

                // pause cycle
                Thread.Sleep(speed);

            }
            //Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Game Over!");
            Console.WriteLine("Your Points Are: {0}", score * 100);
        }
    }
}
