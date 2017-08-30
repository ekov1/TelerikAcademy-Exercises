using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximal_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N-1; i++)
            {
                string connection = 
            }
        }

        public class Node
        {
            private int value;
            private bool hasParent;
            private List<Node> children;

            public Node(int value)
            {
                this.value = value;
                this.children = new List<Node>();
            }

            public int NumberOfChildren
            {
                get
                {
                    return this.children.Count;
                }
            }

            public void AddChild(Node child)
            {
                child.hasParent = true;
                children.Add(child);
            }

            public Node GetNode(int index)
            {
                return this.children[index];
            }
        }
    }
}

