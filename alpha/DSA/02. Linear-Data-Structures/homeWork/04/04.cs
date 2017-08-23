using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        /// <summary>
        /// Write a method that finds the longest subsequence of equal numbers in given List 
        /// and returns the result as new List<int>.
        /// Write a program to test whether the method works correctly.
        /// </summary>

        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 1, 1, 2, 2, 5, 5, 5, 5, 5, 6, 7 };
            List<int> longest = new List<int>();
            List<int> temp = new List<int>();
            int currentN = numbers[0];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == currentN)
                {
                    temp.Add(numbers[i]);
                }
                else
                {
                    if (temp.Count > longest.Count)
                    {
                        longest = temp;
                    }
                    temp = new List<int>();
                    currentN = numbers[i];
                    temp.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", longest));

            Console.WriteLine(test(longest));
        }

        static string test(List<int> listToTest)
        {
            string pWorks = "program works";
            string pFucked = "write new code";
            string answer = "";

            List<int> test1 = new List<int> { 5, 5, 5, 5, 5 };

            if (test1.Count != listToTest.Count)
            {
                answer = pFucked;
                return answer;
            }

            for (int i = 0; i < test1.Count; i++)
            {
                if (test1[i] == listToTest[i])
                {
                    answer = pWorks;
                }
                else
                {
                    answer = pFucked;
                }
            }

            return answer;
        }
    }
}
