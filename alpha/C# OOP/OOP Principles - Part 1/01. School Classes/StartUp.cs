using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School_Classes
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Worker gosho = new Worker();

            decimal goshoZaplataPerHour = gosho.MoneyPerHour();

            Console.WriteLine("gosho poluchava : {0}", goshoZaplataPerHour);

            Student spas = new Student(4);

            Console.WriteLine("spas ocenaka: {0}", spas.Grade );

            Console.ReadLine();
        }
    }
}
