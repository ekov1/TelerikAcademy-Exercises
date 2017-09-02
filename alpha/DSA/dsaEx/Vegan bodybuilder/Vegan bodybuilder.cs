namespace Furniture
{
    using System;
    using System.Collections.Generic;

    public class Item
    {
        public string Name { get; set; }

        public int Weight { get; set; }

        public int Value { get; set; }
    }

    public class FRNTR
    {
        public static void Main()
        {
            // reading the input
            int capacity = int.Parse(Console.ReadLine());
            int itemsCount = int.Parse(Console.ReadLine());

            List<Item> items = new List<Item>();

            for (int i = 0; i < itemsCount; i++)
            {
                string[] currentItemParts = Console.ReadLine().Split(' ');
                items.Add(new Item
                {
                    Name = currentItemParts[0],
                    Weight = int.Parse(currentItemParts[1]),
                    Value = int.Parse(currentItemParts[2])
                });
            }

            // initialising the table, initials are all zeros
            int[,] dp = new int[itemsCount + 1, capacity + 1];
            int[,] backtracking = new int[itemsCount + 1, capacity + 1]; // backtracks information

            // i goes through all items
            for (int i = 1; i <= itemsCount; i++)
            {
                Item currentItem = items[i - 1];
                // j goes through possible capacities
                for (int j = 1; j <= capacity; j++)
                {
                    int notUsedValue = dp[i - 1, j]; // if current item is not used value
                    int usedValue = 0; // if current item is used
                    if (j - currentItem.Weight >= 0)
                    {
                        usedValue = dp[i - 1, j - currentItem.Weight] + currentItem.Value;
                    }

                    if (usedValue >= notUsedValue && usedValue != 0)
                    {
                        dp[i, j] = usedValue;
                        backtracking[i, j] = j - currentItem.Weight;
                    }
                    else
                    {
                        dp[i, j] = notUsedValue;
                    }
                }
            }

            // find max value
            int max = 0;
            int index = 0;
            for (int i = 0; i < capacity + 1; i++)
            {
                if (dp[itemsCount, i] > max)
                {
                    max = dp[itemsCount, i];
                    index = i;
                }
            }

            Console.WriteLine(max);

            for (int i = itemsCount; i > 0; i--)
            {
                if (dp[i, index] != dp[i - 1, index])
                {
                    Console.WriteLine(items[i - 1].Name);
                    index = backtracking[i, index];
                }
            }
        }
    }
}
