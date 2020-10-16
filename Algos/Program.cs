using System;
using Algos.DataStructures;

namespace Algos
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleyLinkedList SLL = new SingleyLinkedList();
            SLL.AddNode(1);
            SLL.AddNode(2);
            SLL.AddNode(3);

            Console.WriteLine(SLL.NodeCount);
        }
    }
}
