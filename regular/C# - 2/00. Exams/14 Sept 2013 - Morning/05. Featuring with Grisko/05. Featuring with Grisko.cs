using System;

namespace _05.Featuring_with_Grisko
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Array.Sort(input);

            int count = 0;

            do
            {
                if (IsMatch(input))
                    count++;
            } while (NextPermutation(input));

            Console.WriteLine(count);
        }
        /// <summary>
        /// Transform array of chars to next permutation.
        /// Rearranges the elements into the next lexicographically greater permutation.
        /// </summary>
        /// <param name="array">The array of elements to be sorted</param>
        /// <returns>
        /// true if the function could rearrange the object as a lexicographically greater permutation.
        /// Otherwise, the function returns false to indicate that the arrangement is not greater than the previous, but the lowest possible (sorted in ascending order).
        /// </returns>
        private static bool NextPermutation(char[] array)
        {
            for (int index = array.Length - 2; index >= 0; index--)
            {
                if (array[index] < array[index + 1])
                {
                    int swapWithIndex = array.Length - 1;
                    while (array[index] >= array[swapWithIndex])
                    {
                        swapWithIndex--;
                    }

                    // Swap i-th and j-th elements
                    var tmp = array[index];
                    array[index] = array[swapWithIndex];
                    array[swapWithIndex] = tmp;

                    Array.Reverse(array, index + 1, array.Length - index - 1);
                    return true;
                }
            }

            // No more permutations
            return false;
        }
        static bool IsMatch(char [] word)
        {
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i - 1] == word[i])
                    return false;
            }

            return true;
        }
    }
}
