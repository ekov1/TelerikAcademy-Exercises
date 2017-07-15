using System;

namespace _03.Compare_char_arrays
{
    // Description

    // Write a program that compares two char arrays lexicographically (letter by letter).
    // Print < if the first array is lexicographically smaller
    // Print > if the second array is lexicographically smaller
    // Print = if the arrays are equal
    class Program
    {
        static void Main(string[] args)
        {
            char[] one, two;

            one = Console.ReadLine().ToCharArray();
            two = Console.ReadLine().ToCharArray();

            CompareLexicographically(one, two);
        }

        private static void CompareLexicographically(char[] one, char[] two)
        {
            int small = Math.Min(one.Length, two.Length);

            string arr1 = new string(one),
                arr2 = new string(two);

            for (int i = 0; i < small; i++)
            {
                if (one[i] < two[i])
                {
                    Console.WriteLine("{0} < {1}", arr1, arr2);
                    break;
                }

                if (one[i] > two[i])
                {
                    Console.WriteLine("{0} > {1}", arr1, arr2);
                    break;
                }

                if (one[i] == two[i] && one.Length == two.Length && i + 1 == small)
                {
                    Console.WriteLine("{0} = {1}", arr1, arr2);
                    break;
                }

                if (one[i] == two[i] && one.Length > two.Length && i + 1 == small)
                {
                    Console.WriteLine("{0} > {1}", arr1, arr2);
                    break;
                }

                if (one[i] == two[i] && one.Length < two.Length && i + 1 == small)
                {
                    Console.WriteLine("{0} < {1}", arr1, arr2);
                    break;
                }
            }
        }
    }
}
