using System;

public class Program
{
    private static void Main()
    {
        double result;
        string value = Console.ReadLine();

        try
        {
            result = double.Parse(value);
            //         Console.WriteLine("Converted the {0} value '{1}' to the {2} value {3}.", value.GetType().Name, value, 
            //         result.GetType().Name, result);
            if (result >= 0) Console.WriteLine("{0:0.000}", Math.Round(Math.Sqrt(result), 3));
            else Console.WriteLine("Invalid number");
        }
        catch (FormatException)
        {
            //         Console.WriteLine("Unable to convert '{0}' to a Single.", value);
            Console.WriteLine("Invalid number");
        }
        catch (OverflowException)
        {
            //        Console.WriteLine("'{0}' is outside the range of a Single.", value);
            Console.WriteLine("Invalid number");
        }

        finally
        {
            Console.WriteLine("Good bye");
        }

    }
}
