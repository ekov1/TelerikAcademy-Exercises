using System;

namespace _11.Binary_to_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            long result = 0;
            string temp = "";
            char[] numbers;


            temp = Console.ReadLine();

            numbers = temp.ToCharArray(0, temp.Length);

            for (i = numbers.Length - 1; i >= 0; i--)
            {
                result += long.Parse(numbers[i] + "\0") * (long)Math.Pow(2, numbers.Length - i - 1);

            }

            Console.WriteLine(result);
        }
    }
}
