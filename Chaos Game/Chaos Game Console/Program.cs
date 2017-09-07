using System;
using System.Diagnostics;
using System.Drawing;

namespace RosettaChaosGame
{
    class Program
    {
        /// <summary>
        /// https://www.youtube.com/watch?v=MBhx4XXJOH8
        /// </summary>

        static void Main(string[] args)
        {
            Console.BufferHeight = Console.WindowHeight = 200;
            Console.BufferWidth = Console.WindowWidth = 200;

            var bm = new Bitmap(200, 200);

            var referencePoints = new Point[] {
                new Point(0, 30),
                new Point(60, 30),
                new Point(31, 18)
            };

            var stepsToGo = 100000000;
            var r = new System.Random();
            var p = new Point(r.Next(60), r.Next(18));
            var stw = new Stopwatch();

            Console.WriteLine("  " + stepsToGo + " steps To Go");
            stw.Start();
            for (int count = 0; count < stepsToGo; count++)
            {
                //Console.CursorVisible = false;
                //Console.SetCursorPosition(0, 1);
                //if (count % 100000 == 0)
                //{
                //    Console.WriteLine("  " + (stepsToGo - count) + " steps left");
                //    Console.WriteLine("  " + count + " steps passed");
                //    Console.WriteLine("  " + stw.ElapsedMilliseconds / 1000 + " s");
                //}


                bm.SetPixel(p.X, p.Y, Color.DodgerBlue);
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write("x");
                int i = r.Next(3);
                p.X = (p.X + referencePoints[i].X) / 2;
                p.Y = (p.Y + referencePoints[i].Y) / 2;
            }

            const string filename = "Chaos Game.png";
            bm.Save(filename);
            Process.Start(filename);
        }
    }
}