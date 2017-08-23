using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> stringQueue = new Queue<string>();

            stringQueue.Enqueue("one");
            stringQueue.Enqueue("two");
            stringQueue.Enqueue("three");
            stringQueue.Enqueue("four");
            stringQueue.Enqueue("five");

            while (stringQueue.Count > 0)
            {
                string number = stringQueue.Dequeue();
                Console.WriteLine(number);
            }
        }
    }
}
