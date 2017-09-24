using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Printing
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = double.Parse(Console.ReadLine());
            double sheetsPerStudent = double.Parse(Console.ReadLine());
            double realmPrice = double.Parse(Console.ReadLine());
            double sheetsInBox = 500;

            double allSheets = students * sheetsPerStudent;
            double boxesToBuy = allSheets / sheetsInBox;
            double endPrice = boxesToBuy * realmPrice;
            Console.WriteLine("{0:F2}",endPrice);

        }
    }
}
