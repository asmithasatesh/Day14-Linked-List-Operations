using LinkedListOperations;
using System;

namespace LinkedListOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Program!");
            OperationsOnLinkedList obj = new OperationsOnLinkedList();
            Console.WriteLine("Enter 1-Create Linked");
            Console.WriteLine("Enter 2-to Add at First");
            Console.WriteLine("Enter 3-to Append data at Last");
            Console.WriteLine("Enter 4-to Add data in between of two nodes in Linked List");
            Console.WriteLine("Enter 5-to Delete at first data of Linked List");
            Console.WriteLine("Enter 6-to Delete Last data of Linked List");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    obj.InsertLast(56);
                    obj.InsertLast(30);
                    obj.InsertLast(70);
                    obj.Display();
                    break;
                case 2:
                    obj.InsertAtFirst(70);
                    obj.InsertAtFirst(30);
                    obj.InsertAtFirst(56);
                    //Display Operation
                    Console.WriteLine("*****Insertion at First*****");
                    obj.Display();
                    break;
                case 3:
                    obj.InsertLast(56);
                    obj.InsertLast(30);
                    obj.InsertLast(70);
                    //Display Operation
                    Console.WriteLine("*****Insertion at Last*****");
                    obj.Display();
                    break;
                case 4:
                    obj.InsertLast(56);
                    obj.InsertLast(70);
                    //Display Operation
                    Console.WriteLine("*****Insertion in Between two nodes*****");
                    obj.Display();
                    obj.InsertInBetween(2, 30);
                    obj.Display();
                    break;
                case 5:
                    obj.InsertLast(56);
                    obj.InsertLast(30);
                    obj.InsertLast(70);
                    obj.Display();
                    //Pop first Node
                    obj.pop();
                    break;
                case 6:
                    obj.InsertLast(56);
                    obj.InsertLast(30);
                    obj.InsertLast(70);
                    obj.Display();
                    //Pop Last Node
                    obj.PopLast();
                    break;
            }
        }
    }
}
