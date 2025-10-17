using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Linked_List_Class.DS
{
    public class clsDblLinkedList<T>
    {

        public class Node
        {

            public T value;
            public Node next;
            public Node prev;

        }

        public Node head = null;

        public void InsertAtBeginning(T value)
        {

            Node newNode = new Node();
            newNode.value = value;
            newNode.next = head;
            newNode.prev = null;

            if (head != null)
            {
                head.prev = newNode;
            }

            head = newNode;

        }

        public void PrintList()
        {

            Node current = head;

            while (current != null)
            {

                Console.Write(current.value + " ");

                current = current.next;

            }

            Console.WriteLine();

        }

        public Node Find(T value)
        {

            Node current = head;

            while (current != null)
            {

                if (current.value.Equals(value))
                {
                    return current;
                }

                current = current.next;

            }

            return null;

        }

        public void InsertAfter(Node current, T value)
        {

            if (current == null) return;

            Node newNode = new Node();
            newNode.value = value;
            newNode.next = current.next;
            newNode.prev = current;

            if (current.next != null)
            {
                current.next.prev = newNode;
            }

            current.next = newNode;

        }

        public void InsertAtEnd(T value)
        {

            Node newNode = new Node();
            newNode.value = value;
            newNode.next = null;

            if (head == null)
            {
                newNode.prev = null;
                head = newNode;
                return;
            }

            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }

            current.next = newNode;
            newNode.prev = current;

        }

        public void DeleteNode(ref Node nodeToDelete)
        {

            if (head == null || nodeToDelete == null)
            {
                return;
            }

            if (head == nodeToDelete)
            {
                head = nodeToDelete.next;
            }

            if (nodeToDelete.next != null)
            {
                nodeToDelete.next.prev = nodeToDelete.prev;
            }

            if (nodeToDelete.prev != null)
            {
                nodeToDelete.prev.next = nodeToDelete.next;
            }

            nodeToDelete = null;

        }

        public void DeleteFirstNode()
        {

            if (head == null) return;

            head = head.next;

            if(head != null)
            {
                head.prev = null;
            }

        }

        public void DeleteLastNode()
        {
            if (head == null) return;

            if(head.next == null)
            {
                head = null;
                return;
            }

            Node current = head;
            while(current.next.next != null)
            {
                current= current.next;
            }

            current.next = null;

        }

    }
}
