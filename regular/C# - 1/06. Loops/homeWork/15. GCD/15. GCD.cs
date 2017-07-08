using System;

public class Program
{
    private static void Main()
    {
        char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
        int a = 0, b = 0, i = 1;

        string temp = "";
        string[] numbers;


        temp = Console.ReadLine();

        numbers = temp.Split(delimiterChars);
        a = int.Parse(numbers[0]);
        b = int.Parse(numbers[1]);

        while (a != b)
        {
            // Console.WriteLine("a = {0}", a);
            // Console.WriteLine("b = {0}", b);
            if (a > b)
                a -= b;
            else
                b -= a;

        }

        Console.WriteLine(a);
    }
}
