using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            linkedList.AddFirst("First");
            linkedList.AddLast("Last");
            linkedList.AddAfter(linkedList.First, "After First");
            linkedList.AddBefore(linkedList.Last, "Before Last");

            Console.WriteLine(string.Join(" ", linkedList));
        }
    }
}
