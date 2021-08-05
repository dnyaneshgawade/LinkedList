using System;
using System.Collections.Generic;
using System.Text;

namespace Data_structure
{
    class LinkedList
    {
        public Node head;
        public void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }

        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("linkedlist is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }
    }
}
