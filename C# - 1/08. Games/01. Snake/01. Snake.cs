using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _01.Snake
{
    struct Position
    {
        public int Row;
        public int Col;

        public Position(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
    }
    class Snake
    {
        static Random rng;

        static Queue<Position> snakeElements = new Queue<Position>();
        static Position snakeHead;
        static Position snakeNewHead;

        static Position[] directions = new Position[4];
        static byte directionIndex;
        static byte right;
        static byte left;
        static byte up;
        static byte down;

        static int lastFoodTime;
        static int foodDisappearTime;
        static Position food;

        static List<Position> obstacles = new List<Position>();
        static Position obstacle;

        static int userPoints;
        static int negativePoints;
        static double sleepTime;
        static bool isGameOver;

        static void Main(string[] args)
        {
            // console setUp
            Console.CursorVisible = false;
            Console.BufferHeight = Console.WindowHeight = 25;
            Console.BufferWidth = Console.WindowWidth = 50;


            InitializeSnakeElements();

            while (!isGameOver)
            {
                negativePoints++;

                // input handler
                InputHandler();

                // move snake
                MoveSnake();

                // eat food logic
                EatFoodLogic();
                // generate new food if not eaten after fixed time
                // game over logic

                // redraw old head
                redrawOldHead();

                // draw new head
                DrawNewHead();

                // draw food
                // add the new snake head
                snakeElements.Enqueue(snakeNewHead);


                sleepTime -= 0.01;
                Thread.Sleep((int)sleepTime);
            }
        }

        private static void EatFoodLogic()
        {
            if (food.Row == snakeNewHead.Row && food.Col == snakeNewHead.Col)
            {
                lastFoodTime = Environment.TickCount;
                userPoints += 50;
                GenerateFood();
                DrawFood();
                GenerateANewObstacle();
                DrawNewObstacle();
                sleepTime -= 5;
            }
            else
            {
                Position snakeTail = snakeElements.Dequeue();
                Console.SetCursorPosition(snakeTail.Col, snakeTail.Row);
                Console.WriteLine(" ");
            }
        }

        private static void DrawNewObstacle()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(obstacle.Col, obstacle.Row);
            Console.WriteLine("#");
        }

        private static void DrawNewHead()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(snakeNewHead.Col, snakeNewHead.Row);
            if (directionIndex == right) Console.Write(">");
            else if (directionIndex == left) Console.Write("<");
            else if (directionIndex == up) Console.Write("^");
            else if (directionIndex == down) Console.Write("v");
        }

        private static void redrawOldHead()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(snakeHead.Col, snakeHead.Row);
            Console.Write("*");
        }

        private static void MoveSnake()
        {
            snakeHead = snakeElements.Last();
            Position nextDirection = directions[directionIndex];
            snakeNewHead = new Position(snakeNewHead.Row + nextDirection.Row, snakeHead.Col + nextDirection.Col);

            // TODO: teleport snake
        }

        private static void InputHandler()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo userinput = Console.ReadKey();
                if (userinput.Key == ConsoleKey.RightArrow && directionIndex != left) directionIndex = right;
                else if (userinput.Key == ConsoleKey.LeftArrow && directionIndex != right) directionIndex = left;
                else if (userinput.Key == ConsoleKey.DownArrow && directionIndex != up) directionIndex = down;
                else if (userinput.Key == ConsoleKey.UpArrow && directionIndex != down) directionIndex = up;
            }
        }

        private static void InitializeSnakeElements()
        {
            rng = new Random();

            for (int i = 0; i < 6; i++)
            {
                snakeElements.Enqueue(new Position(0, i));
            }

            DrawSnakeBody();

            directions = new Position[]
            {
                new Position(0, 1), // right
                new Position(0,-1), // left
                new Position(1, 0), // down
                new Position(-1,0)  // up
            };

            right = 0; left = 1; down = 2; up = 3;
            directionIndex = right;

            GenerateFood();
            lastFoodTime = Environment.TickCount; // counts the time in miliseconds
            foodDisappearTime = 7000; // 1000 miliseconds = 1 second
            DrawFood();

            for (int i = 0; i < 7; i++)
            {
                GenerateANewObstacle();
            }
            DrawObstacles();

            userPoints = 0;
            negativePoints = 0;
            sleepTime = 200;
            isGameOver = false;
        }

        private static void DrawFood()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(food.Col, food.Row);
            Console.Write("@");
        }

        private static void DrawObstacles()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (Position obstacle in obstacles)
            {
                Console.SetCursorPosition(obstacle.Col, obstacle.Row);
                Console.Write("#");
            }
        }

        private static void GenerateANewObstacle()
        {
            do
            {
                obstacle = new Position(rng.Next(0, Console.WindowHeight), rng.Next(0, Console.WindowWidth));
            } while (snakeElements.Contains(obstacle)
            || (food.Row == obstacle.Row && food.Col == obstacle.Col)
            || obstacles.Contains(obstacle));

            obstacles.Add(obstacle);
        }

        private static void GenerateFood()
        {
            do
            {
                food = new Position(rng.Next(0, Console.WindowHeight), rng.Next(0, Console.WindowWidth));
            } while (snakeElements.Contains(food)||obstacles.Contains(food));

            lastFoodTime = Environment.TickCount; //restat apple timer
        }

        private static void DrawSnakeBody()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Position element in snakeElements)
            {
                Console.SetCursorPosition(element.Col, element.Row);
                Console.Write("*");
            }
        }
    }
}
