using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Maze_runner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOdd = 0, sumEven = 0;
            int dg1, dg2, dg3, dg4;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                dg1 = number / 1000;
                //Console.WriteLine(dg1);
                dg2 = (number % 1000) / 100;
                //Console.WriteLine(dg2);
                dg3 = ((number % 1000) % 100) / 10;
                //Console.WriteLine(dg3);
                dg4 = ((number % 1000) % 100) % 10;
                //Console.WriteLine(dg4);

                if (dg1 % 2 == 0)
                {
                    sumEven += dg1;
                }
                else
                {
                    sumOdd += dg1;
                }

                if (dg2 % 2 == 0)
                {
                    sumEven += dg2;
                }
                else
                {
                    sumOdd += dg2;
                }

                if (dg3 % 2 == 0)
                {
                    sumEven += dg3;
                }
                else
                {
                    sumOdd += dg3;
                }

                if (dg4 % 2 == 0)
                {
                    sumEven += dg4;
                }
                else
                {
                    sumOdd += dg4;
                }

                if (sumEven > sumOdd)
                {
                    Console.WriteLine("left");
                }
                else if (sumOdd > sumEven)
                {
                    Console.WriteLine("right");
                }
                else
                {
                    Console.WriteLine("straight");
                }
                sumOdd = 0;
                sumEven = 0;
            }
        }
    }
}
