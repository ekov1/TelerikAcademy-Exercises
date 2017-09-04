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
            var bm = new Bitmap(1200, 1200);

            var referencePoints = new Point[] {
                new Point(0, 1200),
                new Point(1200, 1200),
                new Point(600, 162)
            };
            var r = new System.Random();
            var p = new Point(r.Next(1200), r.Next(1200));
            for (int count = 0; count < 1000000; count++)
            {
                bm.SetPixel(p.X, p.Y, Color.Turquoise);
                //if (count % 2 == 0)
                //{
                //    bm.SetPixel(p.X, p.Y, Color.Gold);
                //}
                int i = r.Next(3);
                p.X = (p.X + referencePoints[i].X) / 2;
                p.Y = (p.Y + referencePoints[i].Y) / 2;
                //p.X = (p.X + referencePoints[i].X) / 3;
                //p.Y = (p.Y + referencePoints[i].Y) / 3;
                //p.X = (p.X + referencePoints[i].X) / 2;
                //p.Y = (p.Y + referencePoints[i].Y) / 4;
            }
            const string filename = "Chaos Game.png";
            bm.Save(filename);
            Process.Start(filename);
        }
    }
}