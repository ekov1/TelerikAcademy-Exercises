using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.Saddy_Kopper
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int i, transCounter = 0;
            BigInteger sum = 0, product = 1;

            while (transCounter < 10)
            {
                while (number.Length > 1)
                {
                    number = number.Substring(0, number.Length - 1);
                    //Console.WriteLine(number);

                    for (i = 0; i < number.Length; i += 2)
                    {
                        sum += (number[i] - '0');
                    }
                    //Console.WriteLine(sum);
                    product *= sum;
                    sum = 0;
                }
                transCounter++;
                number = product.ToString();
                //Console.WriteLine(number);
                product = 1;
                if (number.Length < 2) break;
            }
            if (transCounter < 10) Console.WriteLine(transCounter);
            Console.WriteLine(number);
        }


    }
}
