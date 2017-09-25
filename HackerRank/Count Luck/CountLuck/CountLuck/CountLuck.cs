using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLuck
{
    class CountLuck
    {
        // variables
        static char[,] maze;
        static bool[,] visited;
        static int n;
        static int m;

        static int startingRow;
        static int startingCol;

        // main
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine()); // rons guess
            int[] nm = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            n = nm[0];
            m = nm[1];

            maze = new char[n, m];
            visited = new bool[n, m];

            CreateMazeFromInput();
            // DrawMaze();
            WalkMaze();

        }

        // methods
        private static void WalkMaze()
        {
            CheckNeighbourCells();
        }

        private static void CheckNeighbourCells()
        {
            // check Left
            if (startingCol > 0)
            {
                if (maze[startingRow, startingCol - 1] == '.' && visited[startingRow, startingCol - 1] == false)
                {
                    visited[startingRow, startingCol] = true;
                    startingCol--;
                }
            }

            // check Right
            if (startingCol < m - 1)
            {
                if (maze[startingRow, startingCol + 1] == '.' && visited[startingRow, startingCol + 1] == false)
                {
                    visited[startingRow, startingCol] = true;
                    startingCol++;
                }
            }

            // check Up
            if (startingRow > 0)
            {
                if (maze[startingRow - 1, startingCol] == '.' && visited[startingRow - 1, startingCol] == false)
                {
                    visited[startingRow, startingCol] = true;
                    startingRow--;
                }
            }

            // check Down
            if (startingRow < n - 1)
            {
                if (maze[startingRow - 1, startingCol] == '.' && visited[startingRow - 1, startingCol] == false)
                {
                    visited[startingRow, startingCol] = true;
                    startingRow--;
                }
            }
        }

        private static void CreateMazeFromInput()
        {
            for (int i = 0; i < n; i++)
            {
                string rowAsString = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    maze[i, j] = rowAsString[j];
                    if (rowAsString[j] == 'M')
                    {
                        startingRow = i;
                        startingCol = j;
                    }
                }
            }
        }

        private static void DrawMaze()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(string.Format("{0,2}", maze[i, j]));
                }
                Console.WriteLine();
            }
        }


    }
}
