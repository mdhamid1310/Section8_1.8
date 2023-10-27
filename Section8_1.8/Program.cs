using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoublyLibrary;

namespace Section8_1._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
            Console.ReadLine();
        }

        private static void runApp()
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();

            // Adding nodes to the doubly linked list
            doublyLinkedList.AddNode(1);
            doublyLinkedList.AddNode(2);
            doublyLinkedList.AddNode(3);
            doublyLinkedList.AddNode(4);

            Console.WriteLine("Doubly Linked List (Forward):");
            doublyLinkedList.DisplayList();

            // Display the list in reverse order
            Console.WriteLine("Doubly Linked List (Reverse):");
            Node current = doublyLinkedList.Tail;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Previous;
            }
        }
    }
}
