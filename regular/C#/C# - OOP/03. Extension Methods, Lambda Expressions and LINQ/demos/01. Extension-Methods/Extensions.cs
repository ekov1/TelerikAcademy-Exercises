using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Extension_Methods
{
    public static class Extensions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string ToString<T>(this IEnumerable<T> enumeration)
        {
            var result = new StringBuilder();

            result.Append("[ ");
            foreach (var item in enumeration)
            {
                result.Append(item + " ");
            }
            result.Append("]");
            return result.ToString();
        }

        public static void IncreaseWidth(this List<int> list, int amount)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] += amount;
            }
        }
    }
}
