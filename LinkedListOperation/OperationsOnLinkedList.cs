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
        //Insert a node between two nodes
        public int InsertAtSpecificPosition(int searchdata, int data)
        {
            Node temp = SearchDataAtPosition(searchdata);
            Node newNode = new Node(data);
            newNode.next = temp.next;
            temp.next = newNode;
            Display();
            return (newNode.data);

        }
        public int DeleteInBetween(int data)
        {
            Node temp = SearchDataAtPosition(data);
            Console.WriteLine("\nData {0} has been deleted from linked list", temp.next.data);
            temp.next = temp.next.next;
            int sizeofList = SizeOfList();
            Display();
            return sizeofList;

        }
        public int SizeOfList()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
        //Search a particular data
        public Node SearchDataAtPosition(int value)
        {
            Node temp = head;
            int count = 1;
            while (temp != null)
            {
                if (temp.next.data == value)
                {
                    Console.WriteLine("\nFound {0} at index {1}", temp.data, count);
                    return temp;
                }
                temp = temp.next;
                count++;
            }
            Console.WriteLine("\nCould not find value in Linked List!");
            return default;
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
        public void Add(int data)
        {
            Node newNode = new Node(data);
            Sorted(newNode);
            Console.WriteLine("\n*****DISPLAYING SORTED LINKED LIST VALUES*****");
            Display();

        }
        public void Sorted(Node newNode)
        {
            Node temp = head;
            if (temp == null || head.data >= newNode.data)
            {
                newNode.next = head;
                head = newNode;
            }
            else if (head.next == null && head.data < newNode.data)
            {
                head.next = newNode;
            }
            else
            {
                if (temp.next.data > newNode.data)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                else
                {
                    while (temp.next != null && temp.next.data < newNode.data)
                    {
                        temp = temp.next;
                    }
                    newNode.next = temp.next;
                    temp.next = newNode;

                }
            }
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
