using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_1
{
    class Tree
    {
        /// input
        /// 7
        /// 2 4
        /// 3 2
        /// 5 0
        /// 3 5
        /// 5 6
        /// 5 1

        static Node<int> FindRoot(Node<int>[] nodes)
        {
            var hasParent = new bool[nodes.Length];

            foreach (var node in nodes)
            {
                foreach (var child in node.Children)
                {
                    hasParent[child.Value] = true;
                }
            }

            for (int i = 0; i < hasParent.Length; i++)
            {
                if (!hasParent[i])
                {
                    return nodes[i];
                }
            }
            throw new ArgumentException();
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Node<int>[] nodes = new Node<int>[n];

            for (int i = 0; i < n; i++)
            {
                nodes[i] = new Node<int>(i);
            }

            for (int i = 0; i < n - 1; i++)
            {
                string edgeAsString = Console.ReadLine();
                string[] edgeParts = edgeAsString.Split(' ');

                int parentId = int.Parse(edgeParts[0]);
                int childId = int.Parse(edgeParts[1]);

                nodes[parentId].Children.Add(nodes[childId]);
                nodes[childId].HasParent = true;
            }

            // 1. Find root
            var root = FindRoot(nodes);
            Console.WriteLine("root: " + root.Value);

            // 2. Find all leafs
            var leafs = FindAllLeafs(nodes);
            Console.Write("Leafs:");
            foreach (var leaf in leafs)
            {
                Console.Write("{0}, ", leaf.Value);
            }

            Console.WriteLine();

            // 3. Find all middle nides
            var middleNodes = FindMiddleNodes(nodes);
            Console.Write("midle nodes:");
            foreach (var node in middleNodes)
            {
                Console.Write("{0}, ", node.Value);
            }
        }

        private static List<Node<int>> FindMiddleNodes(Node<int>[] nodes)
        {
            var middleNodes = new List<Node<int>>();

            foreach (var node in nodes)
            {

            }

            return middleNodes;
        }

        private static List<Node<int>> FindAllLeafs(Node<int>[] nodes)
        {
            List<Node<int>> leafs = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    leafs.Add(node);
                }
            }

            return leafs;
        }
    }

    public class Node<T>
    {
        public T Value { get; set; }

        public List<Node<T>> Children { get; set; }

        public bool HasParent { get; set; }

        public Node()
        {
            this.Children = new List<Node<T>>();
        }

        public Node(T value)
            : this()
        {
            this.Value = value;
        }
    }
}
