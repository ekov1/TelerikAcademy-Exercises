using System;

public class Program
{
    private static void Main()
    {
        long A = 0;
        uint rem = 0;
        string result = "";

        A = long.Parse(Console.ReadLine());

        while (A != 0)
        {
            rem = (uint)A % 16;
            if (rem != 0)
            {
                if (rem < 10)
                    result = Convert.ToString(rem) + result;
                else
                    if (rem == 10)
                    result = "A" + result;
                if (rem == 11)
                    result = "B" + result;
                if (rem == 12)
                    result = "C" + result;
                if (rem == 13)
                    result = "D" + result;
                if (rem == 14)
                    result = "E" + result;
                if (rem == 15)
                    result = "F" + result;
            }
            else
                result = "0" + result;
            A = A / 16;
        }

        Console.WriteLine(result);
    }
}
