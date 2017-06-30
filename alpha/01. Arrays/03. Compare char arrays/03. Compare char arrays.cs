using System;

namespace _03.Compare_char_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // a < ab < ac
            // a < ab < abc
            // string.CompareTo -1 0 1
            string a, b, result = "";
            char[] one, two;
            int lenght, i;

            a = Console.ReadLine();
            b = Console.ReadLine();
            
            one = a.ToCharArray();
            two = b.ToCharArray();

            if (a.Length < b.Length)
                lenght = a.Length;
            else
                lenght = b.Length;

            for (i = 0; i < lenght; i++)
            {
                if (one[i] > two[i])
                {
                    result = ">";
                    break;
                }

                if (one[i] < two[i])
                {
                    result = "<";
                    break;
                }

                if (one[i] == two[i] && one.Length == two.Length && i + 1 == lenght)
                {
                    result = "=";
                    break;
                }

                if (one[i] == two[i] && one.Length > two.Length && i + 1 == lenght)
                {
                    result = ">";
                    break;
                }

                if (one[i] == two[i] && one.Length < two.Length && i + 1 == lenght)
                {
                    result = "<";
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
