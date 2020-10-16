using System;
namespace Algos.DataStructures
{
    public class Node
    {
        public int Value;
        public Node Next;
        public Node(int val)
        {
            Value = val;
            Next = null;
        }
    }
    public class SingleyLinkedList
    {
        public Node Head { get; set; }
        public int NodeCount { get; set; }
        public SingleyLinkedList()
        {
            Head = null;
        }

        public void AddNode(int val)
        {
            Node newNode = new Node(val);
            Node curr = this.Head;
            if (curr == null)
            {
                curr = newNode;
            }
            else
            {
                while (curr != null)
                {
                    curr = curr.Next;
                }
                curr.Next = newNode;
            }
            this.NodeCount += 1;
            Console.WriteLine("Done");
        }

    }
}