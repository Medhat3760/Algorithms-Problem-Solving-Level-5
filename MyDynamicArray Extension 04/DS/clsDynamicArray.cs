using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyDynamicArray.DS
{
    public class clsDynamicArray<T>
    {

        protected int _size;
        protected T[] _tempArray;

        public T[] originalArray;

        public clsDynamicArray(int size = 0)
        {

            if (size < 0)
            {
                size = 0;
            }

            _size = size;
            originalArray = new T[_size];

        }

        public bool SetItem(int index, T value)
        {

            if (index < 0 || index >= _size)
            {
                return false;
            }

            originalArray[index] = value;
            return true;

        }

        public bool IsEmpty()
        {
            return _size == 0;
        }

        public int Size
        {
            get
            {
                return _size;
            }
        }

        public void PrintArray()
        {

            foreach (T item in originalArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }

        public void Resize(int newSize)
        {

            if (newSize < 0)
            {
                newSize = 0;
            }

            _tempArray = new T[newSize];

            if (newSize < _size)
            {
                _size = newSize;
            }

            for (int i = 0; i < _size; i++)
            {
                _tempArray[i] = originalArray[i];
            }

            _size = newSize;

            originalArray = _tempArray;

        }

        public T GetItem(int index)
        {

            if (index < 0 || index >= _size)
            {
                throw new IndexOutOfRangeException("out of range");
            }

            return originalArray[index];
        }

        public void Reverse()
        {

            _tempArray = new T[_size];

            for (int i = 0; i < _size; i++)
            {

                _tempArray[i] = originalArray[_size - i - 1];

            }

            originalArray = _tempArray;

        }

        public void Clear()
        {

            _size = 0;
            _tempArray = new T[0];
            originalArray = _tempArray;

        }

        //My Solution
        /*public bool DeleteItemAt(int index)
        {

            if (index < 0 || index >= _size)
            {
                return false;
            }

            _tempArray = new T[_size - 1];

            int counter = 0;
            for (int i = 0; i < _size; i++)
            {

                if (i != index)
                {
                    _tempArray[counter++] = originalArray[i];
                }

            }

            _size--;

            originalArray = _tempArray;

            return true;

        }
        */

        public bool DeleteItemAt(int index)
        {

            if (index < 0 || index >= _size)
            {
                return false;
            }

            _tempArray = new T[_size - 1];

            //copy all before index
            for (int i = 0; i < index; i++)
            {
                _tempArray[i] = originalArray[i];
            }

            //copy all after index
            for (int i = index + 1; i < _size; i++)
            {
                _tempArray[i - 1] = originalArray[i];
            }

            _size--;

            originalArray = _tempArray;

            return true;

        }

        public bool DeleteFirstItem()
        {
            return DeleteItemAt(0);
        }

        public bool DeleteLastItem()
        {
            return DeleteItemAt(_size - 1);
        }

    }
}
