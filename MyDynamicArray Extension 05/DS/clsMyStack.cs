using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyQueue_Class.DS;
namespace MyStack.DS
{
    public class clsMyStack<T> : clsMyQueue<T>
    {

        public void Push(T item)
        {
            _myList.InsertAtBeginning(item);
        }

        public T Top()
        {
            return Front();
        }

        public T Bottom()
        {
            return Back();
        }

    }
}
