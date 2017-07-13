using System;


public class Program
{
    private static void Main()
    {
        int result, prev_num = 0;
        string str_result = "";

        for (int i = 0; i < 10; i++)
        {
            string value = Console.ReadLine();

            try
            {
                result = Convert.ToInt32(value);
                if (result <= 1 || result >= 100)
                {
                    Console.WriteLine("Exception");
                    break;
                }


                if (i != 0)
                {
                    if (result <= prev_num)
                    {
                        Console.WriteLine("Exception");
                        break;
                    }

                }
                prev_num = result;

                str_result = str_result + " < " + result.ToString();

            }


            catch (FormatException)
            {
                Console.WriteLine("Exception");
                break;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Exception");
                break;
            }

            if (i == 9) Console.WriteLine("1" + str_result + " < 100");
        }


    }
}
