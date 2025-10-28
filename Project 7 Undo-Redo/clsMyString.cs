using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7_Undo_Redo
{
    public class clsMyString
    {

        private string _value = string.Empty;

        private Stack<string> _undo = new Stack<string>();
        private Stack<string> _redo = new Stack<string>();

        public string Value
        {

            get
            {
                return _value; 
            }

            set
            {

                _undo.Push(_value);
                _value = value;
                _redo.Clear();

            }

        }

        public void Undo()
        {

            if (_undo.Count >0)
            {
                _redo.Push(_value);
                _value = _undo.Pop();
            }

        }
        
        public void Redo()
        {

            if (_redo.Count >0)
            {
                _undo.Push(_value);
                _value = _redo.Pop();
            }
            
        }

    }
}
