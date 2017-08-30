using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guitar
{
    /// <summary>
    /// 5        4                14
    /// 5 3 7    15 2 9 10        74 39 127 95 63 140 99 96 154 18 137 162 14 88
    /// 5        8                40
    /// 10       20               40
    /// = 10     = -1             = 238
    /// </summary>
    class guitar
    {
        static void Main(string[] args)
        {
            int cNumberOfSongs = int.Parse(Console.ReadLine());
            int[] volumesInteger =
                Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int bStart = int.Parse(Console.ReadLine());
            int mMax = int.Parse(Console.ReadLine());

            int[,] dpMatrix = new int[cNumberOfSongs + 1, mMax + 1];

            dpMatrix[0, bStart] = 1;

            for (int currentVolume = 1; currentVolume < cNumberOfSongs + 1; currentVolume++)
            {
                for (int possibleVolume = 0; possibleVolume < mMax+1; possibleVolume++)
                {
                    if (dpMatrix[currentVolume-1,possibleVolume]==1)
                    {
                        int newVolume = 
                        if (possibleVolume-volumesInteger[currentVolume]>=0)
                        {
                            dpMatrix[currentVolume, possibleVolume]
                        }
                    }
                }
            }




        }
    }
}
