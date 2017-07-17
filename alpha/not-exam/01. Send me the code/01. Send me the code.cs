using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Send_me_the_code
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp, length = "";
            long result = 0, digit, s,nl=0;

            char[] n = Console.ReadLine().ToCharArray();
            n = n.Reverse().ToArray();

            nl = n.Length;
            if (n[n.Length - 1] == '-')
                nl--;

            //foreach (var item in number)
            //{
            //    Console.Write(item);
            //}

            for (long i = 0; i < nl; i++)
            {
                digit = long.Parse(n[i] + "");
                //Console.WriteLine(digit);

                if ((i + 1) % 2 == 0)
                {
                    result += ((i + 1) * (long)Math.Pow(digit, 2));
                }
                else
                {
                    result += (digit * (long)Math.Pow((i + 1), 2));
                }
            }
            //Console.WriteLine(result);
            temp = result.ToString();

            if (temp[temp.Length - 1] == '0')
            {
                temp = "Big Vik wins again!";
                Console.WriteLine(result);
                Console.WriteLine(temp);
            }
            else
            {
                Console.WriteLine(result);
                length = temp[temp.Length - 1] + "";

                s = result % 26;
                s += 97;
                if (s > 122)
                    s = 97;

                for (long i = 0; i < long.Parse(length); i++)
                {

                    Console.Write(Convert.ToChar(s).ToString().ToUpper());
                    s++;
                    if (s > 122)
                        s = 97;
                }
            }
        }
    }
}