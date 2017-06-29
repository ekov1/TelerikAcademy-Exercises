using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Text_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int number = int.Parse(Console.ReadLine());
                string text = Console.ReadLine();
                text = text.ToLower();
                // Console.WriteLine(text);

                long result = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    char ch = text[i];

                    if (ch == '@')
                    {
                        break;
                    }
                    else if ('0' <= ch && ch <= '9')
                    {
                        //int x = Convert.ToInt32(ch);
                        //result *= x;
                        result *= ch - '0';
                    }
                    else if ('a' <= ch && ch <= 'z')
                    {
                        result += (ch - 'a');
                    }
                    else
                    {
                        result = result % number;
                    }
                }
               
                Console.WriteLine(result);
            }

        }
    }
}
