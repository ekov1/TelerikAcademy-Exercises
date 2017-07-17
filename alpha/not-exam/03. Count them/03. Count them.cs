using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Count_them
{
    class Program
    {
        static void Main(string[] args)
        {
            int br = 0, index;
            string temp = "", variable = "";
            List<int> indx = new List<int>();

            do
            {
                temp = Console.ReadLine();

                if (!temp.Contains("//") && !temp.Contains("/*") && !temp.Contains("*/"))
                {
                    index = temp.IndexOf("@");
                }


            } while (temp != "{!}");

            Console.WriteLine(4);

        }
    }
}
