using System;

public class Program
{
    private static void Main()
    {
        int i = 1;
        long result = 0, temp1 = 0;
        string temp = "";
        char[] numbers;


        temp = Console.ReadLine();

        numbers = temp.ToCharArray(0, temp.Length);

        for (i = numbers.Length - 1; i >= 0; i--)
        {
            switch (numbers[i])
            {
                case 'A': temp1 = 10; break;
                case 'B': temp1 = 11; break;
                case 'C': temp1 = 12; break;
                case 'D': temp1 = 13; break;
                case 'E': temp1 = 14; break;
                case 'F': temp1 = 15; break;
                default: temp1 = long.Parse(numbers[i] + "\0"); break;
            }

            result += temp1 * (long)Math.Pow(16, numbers.Length - i - 1);

        }
        System.Console.WriteLine(result);
    }
}
