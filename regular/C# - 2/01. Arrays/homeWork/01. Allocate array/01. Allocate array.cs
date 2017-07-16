using System;

namespace _01.Allocate_array
{
    class Program
    {
        // Description

        // Write a program that allocates array of N integers,
        // initializes each element by its index multiplied by 5
        // and then prints the obtained array on the console.
        static void Main(string[] args)
        {
            int n, i;
            int[] integers;

            n = int.Parse(Console.ReadLine());
            integers = new int[n];

            for (i = 0; i < n; i++)
            {
                integers[i] = i * 5;
            }

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(integers[i]);
            }
        }
    }
}
