using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Employee_Data
{
    class Employee_Data
    {
        static void Main(string[] args)
        {
            string fn = "първо ими";
            string ln = "послидно ими";
            int age = 100;
            string gender = "мале";
            long idNum = 8306112507;
            int emplNum = 27569999;

            string result = " first name: " + fn + "\n" 
                + " last name: " + ln + "\n" 
                + " age: " + age + "\n" 
                + " gender: " + gender + "\n" 
                + " idNum: "+idNum + "\n" 
                + " emplNum: " + emplNum + "\n" ;

            Console.WriteLine(result);
        }
    }
}
