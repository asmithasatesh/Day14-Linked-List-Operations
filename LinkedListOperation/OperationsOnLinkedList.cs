using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListOperations
{
    public  class OperationsOnLinkedList
    {
        public Node head;
        //Insert data to Last
        public void InsertLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;
            }
        }
        //To get Last Node
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        //Insert data to First
        public void InsertAtFirst(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }

        }
        //Search a particular data
        public int SearchData(int value)
        {
            Node temp = head;
            int count = 1;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("\nFound {0} at index {1}", temp.data, count);
                    return temp.data;
                }
                temp = temp.next;
                count++;
            }
            Console.WriteLine("\nCould not find value in Linked List!");
            return default;
        }
        //Insert a node between two nodes
        public void InsertInBetween(int position, int data)
        {
            Node newNode = new Node(data);
            if (position == 1)
            {
                newNode.next = this.head;
                head = newNode;
            }
            else if (position < 1)
            {
                Console.WriteLine(" Value less than 1! Invalid Position.");
            }
            else if (position > 0)
            {
                Node temp = head;
                while (position >= 0)
                {
                    if (position == 2)
                    {
                        Console.WriteLine("\n******After inserting in between Two nodes***** ");
                        newNode.next = temp.next;
                        temp.next = newNode;
                        break;
                    }
                    temp = temp.next;
                    Console.WriteLine(position);
                    position--;
                }

            }
        }
        //Pop first Node
        public void pop()
        {
            Console.WriteLine("\nPoped element is: {0}", head.data);
            this.head = this.head.next;
            Display();
        }
        //Delete at Last
        public void PopLast()
        {
            Console.WriteLine("\n*****Delete Last node*****");
            Node temp = DeleteLastNode();
            Console.WriteLine("Poped element is: {0}", temp.next.data);
            temp.next = null;
            Display();
        }
        public Node DeleteLastNode()
        {
            Node temp = this.head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        //Display Linked list Data
        public void Display()
        {
            int count = 1;
            Node temp = this.head;
            while (temp != null)
            {
                Console.WriteLine("Element {0} of Linked List: {1} ", count, temp.data);
                temp = temp.next;
                count++;
            }
        }
    }
}
