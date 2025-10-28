using Double_Linked_List_Class.DS;
using MyDynamicArray.DS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueueArr.DS
{
    public class clsMyQueueArr<T>
    {

        protected clsDynamicArray<T> _myArr = new clsDynamicArray<T>();

        public void Push(T item)
        {
            _myArr.InsertAtEnd(item);
        }

        public void Pop()
        {
            _myArr.DeleteFirstItem();
        }

        public T Front()
        {
            return _myArr.GetItem(0);
        }

        public T Back()
        {
            return _myArr.GetItem(_myArr.Size - 1);
        }

        public bool IsEmpty()
        {
            return _myArr.IsEmpty();
        }

        public int Size()
        {
            return _myArr.Size;
        }

        public void Print()
        {
            _myArr.PrintArray();
        }

        public T GetItem(int index)
        {
            return _myArr.GetItem(index);
        }

        public void Reverse()
        {
            _myArr.Reverse();
        }

        public bool UpdateItem(int index, T newValue)
        {
            return _myArr.SetItem(index, newValue); 
        }

        public bool InsertAfter(int index, T item)
        {
            return _myArr.InsertAfter(index, item);
        }

        public void InsertAtFront(T item)
        {
            _myArr.InsertAtBeginning(item);
        }

        public void InsertAtBack(T item)
        {
            _myArr.InsertAtEnd(item);
        }

        public void Clear()
        {
            _myArr.Clear();
        }

    }
}
