using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Point__Circle__Rectangle
{
    class Program
    {
        static void Main(string[] args)
        { //Кординати точка
            double DCoordX = double.Parse(Console.ReadLine());
            double DCoordY = double.Parse(Console.ReadLine());
            string rectangle_status, circle_status;

            //Проверка правоъгълник

            if (DCoordX < -1 || DCoordX > 5 || DCoordY > 1 || DCoordY < -1)
            {
                rectangle_status = "outside rectangle";
            }
            else
            {
                rectangle_status = "inside rectangle";
            }

            DCoordX--;
            DCoordY--; // DCoordY = DCoordY-1;
            if (DCoordX * DCoordX + DCoordY * DCoordY > 1.5 * 1.5)
                circle_status = "outside circle";
            else
                circle_status = "inside circle";

            //Отговор

            Console.WriteLine("{0} {1}", circle_status, rectangle_status);

        }
    }
}
