using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFoundationApp_Challenge1
{
    class LinkedList
    {
        public Node head;

        public void Add(int value)
        {
            Node newNode = new Node();
            newNode.value = value;
            newNode.nextNode = head;
            head = newNode;
        }

        public void Insert(int index, int value)
        {
            var current = head;
            for(int i = 0; i < index - 2; i++)
            {
                if (current.nextNode is not null)
                {
                    current = current.nextNode;
                }
                else throw new IndexOutOfRangeException();
            } 
            var temp = current.nextNode;
            current.nextNode = new Node(value, temp);
        }

        public void Print()
        {
            var current = head;
            while(current.nextNode is not null)
            {
                Console.Write(current.value.ToString() + " -> ");
                current = current.nextNode;
            }
            Console.WriteLine();
        }

        public class Node
        {
            public int value;
            public Node nextNode;

            public Node()
            {
                this.value = 0;
                this.nextNode = null;
            }

            public Node(int value, Node nextNode)
            {
                this.value = value;
                this.nextNode = nextNode;
            }
        }
    }
}
