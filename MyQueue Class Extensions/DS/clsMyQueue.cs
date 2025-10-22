using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Double_Linked_List_Class.DS;
namespace MyQueue_Class.DS
{
    public class clsMyQueue<T>
    {

        protected clsDblLinkedList<T> _myList = new clsDblLinkedList<T>();

        public void Push(T item)
        {
            _myList.InsertAtEnd(item);
        }

        public void Pop()
        {
            _myList.DeleteFirstNode();
        }

        public T Front()
        {
            return _myList.GetItem(0);
        }

        public T Back()
        {
            return _myList.GetItem(_myList.Size - 1);
        }

        public bool IsEmpty()
        {
            return _myList.IsEmpty();
        }

        public int Size()
        {
            return _myList.Size;
        }

        public void Print()
        {
            _myList.PrintList();
        }

        public T GetItem(int index)
        {
            return _myList.GetItem(index);
        }

        public void Reverse()
        {
            _myList.Reverse();
        }

        public bool UpdateItem(int index, T newValue)
        {
            return _myList.UpdateItem(index, newValue);
        }

        public bool InsertAfter(int index, T item)
        {
            return _myList.InsertAfter(index, item);
        }

        public void InsertAtFront(T item)
        {
            _myList.InsertAtBeginning(item);
        }

        public void InsertAtBack(T item)
        {
            _myList.InsertAtEnd(item);
        }

        public void Clear()
        {
            _myList.Clear();
        }

    }
}
