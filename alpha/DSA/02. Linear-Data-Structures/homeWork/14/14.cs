using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static string[,] labyrinth = new string[,]
    {
                { "0", "0", "0", "x", "0", "x"},
                { "0", "x", "0", "x", "0", "x"},
                { "0", "*", "x", "0", "x", "0"},
                { "0", "x", "0", "0", "0", "0"},
                { "0", "0", "0", "x", "x", "0"},
                { "0", "0", "0", "x", "0", "x"},
    };
        static bool[,] visited = new bool[labyrinth.GetLength(0), labyrinth.GetLength(1)];
        static void Main(string[] args)
        {
            printMatrix(labyrinth);
            Console.WriteLine();
            // start [2,1]
            DFS(2, 1);
            Console.WriteLine();
            printMatrix(labyrinth);
        }

        static void DFS(int i, int j)
        {
            int waveCount = 0;
            Stack<Tuple<int, int>> cellsToCheck = new Stack<Tuple<int, int>>();

            Tuple<int, int> start = new Tuple<int, int>(i, j);
            cellsToCheck.Push(start);

            while (cellsToCheck.Count > 0)
            {
                Tuple<int, int> currentCell = cellsToCheck.Pop();

                int row = currentCell.Item1;
                int col = currentCell.Item2;
                visited[row, col] = true;
                labyrinth[row, col] = "d";
                // check Up
                if (CheckCell(row - 1, col) && !visited[row - 1, col])
                {
                    visited[row - 1, col] = true;
                    cellsToCheck.Push(new Tuple<int, int>(row - 1, col));
                    labyrinth[row - 1, col] = "d";
                }
                // check Down
                if (CheckCell(row + 1, col) && !visited[row + 1, col])
                {
                    visited[row + 1, col] = true;
                    cellsToCheck.Push(new Tuple<int, int>(row + 1, col));
                    labyrinth[row + 1, col] = "d";
                }
                // check Left
                if (CheckCell(row, col - 1) && !visited[row, col - 1])
                {
                    visited[row, col - 1] = true;
                    cellsToCheck.Push(new Tuple<int, int>(row, col - 1));
                    labyrinth[row, col - 1] = "d";
                }
                // check Right
                if (CheckCell(row, col + 1) && !visited[row, col + 1])
                {
                    visited[row, col + 1] = true;
                    cellsToCheck.Push(new Tuple<int, int>(row, col + 1));
                    labyrinth[row, col + 1] = "d";
                }

                waveCount++;
                // Console.WriteLine(waveCount);
                printMatrix(labyrinth);
                Console.ReadLine();
                Console.WriteLine();
            }
        }

        static bool CheckCell(int row, int col)
        {
            bool answer = true;
            // Console.WriteLine(row + " " + col);
            if ((row < 0 || row >= labyrinth.GetLength(0)) || (col < 0 || col >= labyrinth.GetLength(1)))
            {
                answer = false; // out of the matrix
            }
            else if (labyrinth[row, col] == "x")
            {
                answer = false; // cell is a wall
            }
            else if (labyrinth[row, col] == "0")
            {
                answer = true;
            }

            return answer;
        }

        static void printMatrix(string[,] matrix)
        {
           // Console.SetCursorPosition(0, 0);
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    string y = matrix[i, j] + " ";
                    string x = string.Format("{0,-3}", y);
                    Console.Write(x);
                }
                Console.WriteLine();
            }
        }
    }
}
