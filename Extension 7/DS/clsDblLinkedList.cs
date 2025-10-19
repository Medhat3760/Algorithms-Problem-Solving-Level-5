using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Linked_List_Class.DS
{
    public class clsDblLinkedList<T>
    {

        protected int _size;

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

            _size++;

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

            _size++;

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
                _size++;
                return;
            }

            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }

            current.next = newNode;
            newNode.prev = current;

            _size++;
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

            _size--;

        }

        public void DeleteFirstNode()
        {

            if (head == null) return;

            head = head.next;

            if (head != null)
            {
                head.prev = null;
            }

            _size--;

        }

        public void DeleteLastNode()
        {
            if (head == null) return;

            if (head.next == null)
            {
                head = null;
                _size--;
                return;
            }

            Node current = head;
            while (current.next.next != null)
            {
                current = current.next;
            }

            current.next = null;

            _size--;

        }

        public int Size
        {
            get { return _size; }
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }

        public void Clear()
        {
            while (_size > 0)
            {
                DeleteFirstNode();
            }
        }

        public void Reverse()
        {

            if(head == null || head.next == null) return;

            Node current = head;
            Node temp = null;

            while (current != null)
            {

                // Swap prev and next
                temp = current.prev;
                current.prev = current.next;
                current.next = temp;

                // Move to next node 
                current = current.prev;

            }

            if(temp != null)
            {
                head = temp.prev;
            }

        }

        public Node GetNode(int index)
        {

            if (index < 0 || index >= _size) return null;

            Node current = head;
            for (int i = 0; i <index; i++)
            {
                current = current.next;
            }

            return current;

        }

        public T GetItem(int index)
        {
            if (index < 0 || index >= _size)
            {
                throw new IndexOutOfRangeException("Invalid Index.");
            }

            return GetNode(index).value;
        }

        public bool UpdateItem(int index, T newItem)
        {

            if(index <0 || index >= _size)
            {
                return false;
            }

            Node itemNode = GetNode(index);
            itemNode.value= newItem;

            return true;

        }

    }
}
