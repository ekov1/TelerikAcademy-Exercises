using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace _07.Regional_Settings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Това е кирилица: ☺");
            Console.WriteLine("© Николай Костов, 2011");

            // This will not be displayed in case the
            // Console font does not support Arabic
            Console.WriteLine("السلام عليكم");

            double value = 3.54;
            Console.WriteLine("The value is: {0}", value);
            // Two possible outputs:
            //  - The value is 3.54
            //  - The value is 3,54

            // Change the decimal separator to "."
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("The value is: {0}", value);
            // The value is 3.54

            // Try entering "1.56" and also "1,2,3,4,5"
            decimal d = Decimal.Parse(Console.ReadLine());
            Console.WriteLine(d);
        }
    }
}
