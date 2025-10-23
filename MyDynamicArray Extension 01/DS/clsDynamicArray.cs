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
        protected T[] tempArray;

        public T[] originalArray;

        public clsDynamicArray(int size =0)
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

            if(index <0 || index >= _size)
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

            foreach(T item in originalArray)
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

            tempArray = new T[newSize];

            if (newSize < _size)
            {
                _size = newSize;
            }

            for(int i = 0; i < _size; i++)
            {
                tempArray[i] = originalArray[i];
            }

            _size = newSize;

            originalArray = tempArray;

        }

    }
}
