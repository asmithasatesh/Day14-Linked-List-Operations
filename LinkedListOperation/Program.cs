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
            Console.WriteLine("Enter 7-to Search data from Linked List");
            Console.WriteLine("Enter 8-to Add node at specified position from Linked List");
            Console.WriteLine("Enter 9-to Delete specified node and  print size of Linked List");
            Console.WriteLine("Enter 10-to sort Linked List in Ascending order during Insertion");
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
                case 7:
                    obj.InsertLast(56);
                    obj.InsertLast(30);
                    obj.InsertLast(70);
                    obj.Display();
                    //Pop Last Node
                    int searchValue = obj.SearchData(30);
                    Console.WriteLine(searchValue);
                    break;
                case 8:
                    obj.InsertLast(56);
                    obj.InsertLast(30);
                    obj.InsertLast(70);
                    obj.Display();
                    int value = obj.InsertAtSpecificPosition(30, 40);
                    Console.WriteLine("Inserted Value {0} to linked List", value);
                    break;
                case 9:
                    obj.InsertLast(56);
                    obj.InsertLast(30);
                    obj.InsertLast(40);
                    obj.InsertLast(70);
                    obj.Display();
                    //Usecase 9- Seach and delete an element
                    int linkedListSize = obj.DeleteInBetween(40);
                    Console.WriteLine("\nTotal size of Linked list is: {0}", linkedListSize);
                    break;
                case 10:
                    obj.Add(56);
                    obj.Add(30);
                    obj.Add(40);
                    obj.Add(70);
                    break;
            }
        }
    }
}
