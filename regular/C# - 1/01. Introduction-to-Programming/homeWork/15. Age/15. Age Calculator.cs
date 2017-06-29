using System;

namespace _15.Age
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that reads your birthday(in the format MM.DD.YYYY) 
             * from the console and prints on the console how old you are you now 
             * and how old will you be after 10 years. */

            string strBdate;
            strBdate = Console.ReadLine();

            DateTime bd = Convert.ToDateTime(strBdate);
            DateTime today = DateTime.Today;

            //Console.WriteLine("Your Birthday is: " + bd);
            //Console.WriteLine("Today is: " + today);

            TimeSpan tsYourAge = today - bd;
            //Console.WriteLine("you timespan is " + tsYourAge);

            double yourDays = tsYourAge.Days;
            //Console.WriteLine("you survived " + yourDays + " days");

            double age = Math.Truncate(yourDays / 365.25);
            //Console.WriteLine("you are " + age + " years old");

            double agePlusTenYears = age + 10;
            //Console.WriteLine("after 10 years you will be " + agePlusTenYears + " years old");

            Console.WriteLine(age);
            Console.WriteLine(agePlusTenYears);
        }
    }
}
