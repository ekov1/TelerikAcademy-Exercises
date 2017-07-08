using System;

public class Program
{
    private static void Main()
    {

        uint res = 0, temp = 1, N = 5;

        N = uint.Parse(Console.ReadLine());
        if (N >= 5)
            do
            {
                temp = N / 5;
                if (temp != 0)
                {
                    res = res + temp;
                    N = temp;
                }
                else
                {
                    break;
                }
            }
            while (true);

        //res = N / 5 + N /25;
        Console.WriteLine(res);
    }
}
