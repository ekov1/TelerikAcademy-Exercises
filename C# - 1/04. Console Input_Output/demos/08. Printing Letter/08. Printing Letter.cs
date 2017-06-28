using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Printing_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter person name: ");
            string person = Console.ReadLine();

            Console.Write("Enter company name: ");
            string company = Console.ReadLine();

            Console.WriteLine("  Dear {0},", person);
            Console.WriteLine(
                "We are pleased to tell you \n" +
                "that {0} has chosen you to take part \n" +
                "in the \"Introduction To Programming\" " +
                "course. {0} wishes you good luck!",
                company);

            Console.WriteLine("  Yours,");
            Console.WriteLine("  {0}", company);
        }
    }
}
