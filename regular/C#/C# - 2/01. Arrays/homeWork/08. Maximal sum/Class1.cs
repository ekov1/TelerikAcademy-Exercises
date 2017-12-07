using System;
class Program
{
    static void Main()
    {
        //Console.write("enter the number of elements your array will contain: "); //<----------  decomment these lines to enter your own array
        //int n = int.Parse(Console.ReadLine());
        //int[] arr = new int[n];
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = int.Parse(Console.ReadLine());
        //}

        int[] arr = { -2, -3, -6, -1, -2, -1, -6, -4, -8, -8 };
        int currentSum = 0;
        int maxSum = 0;


        for (int i = 0; i < arr.Length; i++)
        {
            currentSum = arr[i] + currentSum;

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
            if (currentSum < 0)
            {
                currentSum = 0;
            }
        }
        Console.WriteLine();
        Console.WriteLine("The maximal sum of a subarray is: {0}", maxSum);
        Console.WriteLine();


    }
}