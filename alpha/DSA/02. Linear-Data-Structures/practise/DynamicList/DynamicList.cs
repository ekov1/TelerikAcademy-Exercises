using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicList
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    /// <summary>
    /// Represents dynamic list implementation
    /// </summary>
    class DynamicList
    {
        private class Node
        {
            // Fields
            private object element;
            private Node next;

            // Constructors
            public Node(object element, Node prevNode)
            {
                this.element = element;
                prevNode.next = this;
            }

            public Node(object element)
            {
                this.element = element;
                next = null;
            }

            // Properties
            public object Element
            {
                get
                {
                    return element;
                }
                set
                {
                    element = value;
                }
            }

            public Node Next
            {
                get
                {
                    return next;
                }
                set
                {
                    next = value;
                }
            }
        }

        // Fields
        private Node head;
        private Node tail;
        private int count;

        // Constructors
        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        // Methods
        /// <summary>
        /// Add element at the end of the list
        /// </summary>
        /// <param name="item">The element you want to add</param>
        public void Add(object item)
        {
            if (head == null)
            {
                // We have empty list
                head = new Node(item);
                tail = head;
            }
            else
            {
                // We have a non-empty list
                Node newNode = new Node(item, tail);
                tail = newNode;
            }
            count++;
        }

        /// <summary>
        /// Removes and returns element on the specific index
        /// </summary>
        /// <param name="index">
        /// The index of the element you want to remove
        /// </param>
        /// <returns>The removed element</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">Index is invalid</exception>
        public object RemoveAt(int index)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index: " + index);
            }

            // Find the elemet at the specified index
            int currentIndex = 0;
            Node currentNode = head;
            Node prevNode = null;

            while (currentIndex < index)
            {
                prevNode = currentNode;
                currentNode = currentNode.Next;
                currentIndex++;
            }

            // Remove the element
            count--;
            if (count == 0)
            {
                head = null;
            }
            else if (prevNode == null)
            {
                head = currentNode.Next;
            }
            else
            {
                prevNode.Next = currentNode.Next;
            }

            // Find last element
            Node lastElement = null;
            if (this.head != null)
            {
                lastElement = this.head;
                while (lastElement.Next != null)
                {
                    lastElement = lastElement.Next;
                }
            }
            tail = lastElement;

            return currentNode.Element;
        }

        /// <summary>
        /// Removes the specified item and return its index
        /// </summary>
        /// <param name="item">The item for removal</param>
        /// <returns>The index of the element or -1 if does not exist</returns>
        public int Remove(object item)
        {
            int currentIndex = 0;
            Node currentNode = head;
            Node prevNode = null;

            while (currentNode != null)
            {
                if ((currentNode.Element != null&& currentNode.Element.Equals(item))
                    || ((currentNode.Element == null) && item == null))
                {
                    break;
                }
                prevNode = currentNode;
                currentNode = currentNode.Next;
                currentIndex++;
            }

            if (currentNode != null)
            {
                // Element is found in the list. Remove it]
                count--;
                if (count == 0)
                {
                    head == null;
                }
            }
        }

    }


}
