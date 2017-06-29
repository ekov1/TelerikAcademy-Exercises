using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Company_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine(),
                companyAddress = Console.ReadLine(),
                phoneNumber = Console.ReadLine(),
                faxNumber = Console.ReadLine(),
                webSite = Console.ReadLine(),
                managerFirstName = Console.ReadLine(),
                managerLastName = Console.ReadLine(),
                managerAge = Console.ReadLine(),
                managerPhone = Console.ReadLine();

            if (faxNumber == "") faxNumber = "(no fax)";

            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + companyAddress);
            Console.WriteLine("Tel. " + phoneNumber);
            Console.WriteLine("Fax: " + faxNumber);
            Console.WriteLine("Web site: " + webSite);
            Console.WriteLine("Manager: " + managerFirstName + " " + managerLastName + " (age: " + managerAge + ", tel. " + managerPhone + ")");
        }
    }
}
