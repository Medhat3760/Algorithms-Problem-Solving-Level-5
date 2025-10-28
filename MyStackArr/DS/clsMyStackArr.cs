using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyQueueArr.DS;
namespace MyStackArr.DS
{
    public class clsMyStackArr<T> : clsMyQueueArr<T>
    {
        public void Push(T item)
        {
            _myArr.InsertAtBeginning(item);
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
