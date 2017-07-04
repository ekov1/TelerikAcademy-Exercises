using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parse_tags
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;

            text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            //text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            while (text.IndexOf("<") > 0)
            {
                sb.Append(text.Substring(0, text.IndexOf("<")));
                text = text.Remove(0, text.IndexOf(">") + 1);
                Console.WriteLine(text);
                Console.WriteLine();

                sb.Append(text.Substring(0, text.IndexOf("<")).ToUpper());
                text = text.Remove(0, text.IndexOf(">") + 1);
                Console.WriteLine(text);
                Console.WriteLine();
                //break;
            }
            sb.Append(text);

            Console.WriteLine(sb.ToString());
            //Console.WriteLine(text);
        }
    }
}
