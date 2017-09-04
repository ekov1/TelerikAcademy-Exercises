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
            var bm = new Bitmap(4800, 4800);

            var referencePoints = new Point[] {
                new Point(0, 4800),
                new Point(4800, 4800),
                new Point(2400, 648)
            };

            var r = new System.Random();
            var p = new Point(r.Next(4800), r.Next(4800));

            for (int count = 0; count < 100000000; count++)
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Drawing the image. Please wait . . .");

                bm.SetPixel(p.X, p.Y, Color.DodgerBlue);
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