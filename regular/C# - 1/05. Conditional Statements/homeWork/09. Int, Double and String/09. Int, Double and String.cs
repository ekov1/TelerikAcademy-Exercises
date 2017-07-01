using System;

namespace _09.Int__Double_and_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string value = Console.ReadLine();

            double n;

            switch (type)
            {
                case "integer":
                    n = int.Parse(value);
                    Console.WriteLine(n + 1);
                    break;
                case "real":
                    n = double.Parse(value);
                    n = n + 1; //    ++n
                    Console.WriteLine("{0:F2}", n);
                    break;
                case "text":
                    value = value + "*";
                    Console.WriteLine(value);
                    break;
            }
        }
    }
}