using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Mythical_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int firstDigit = number / 100;
            //Console.WriteLine(firstDigit);

            int secondDigit = (number % 100) / 10;
           // Console.WriteLine(secondDigit);

            int thirdDigit = (number % 100) % 10;
            // Console.WriteLine(thirdDigit);

            double first = firstDigit, 
                second =secondDigit, 
                third = thirdDigit;

            double result = 0;

            if (thirdDigit == 0)
            {
                result = first * second;
            }
            else if (thirdDigit <= 5)
            {
                result = (first * second) / third;
            }
            else if (thirdDigit > 5)
            {
                result = (first + second) * third;
            }
            Console.WriteLine("{0:F2}",result);
        }
    }
}
