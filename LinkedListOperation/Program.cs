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
            Console.WriteLine("Enter 1 to Add at Last");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    obj.InsertLast(56);
                    obj.InsertLast(30);
                    obj.InsertLast(70);
                    obj.Display();
                    break;
            }
        }
    }
}
