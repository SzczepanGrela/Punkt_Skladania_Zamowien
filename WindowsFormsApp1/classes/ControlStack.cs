using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1.classes
{
    public class ControlStack   // stack of user controls, forms and other containers
    {
        private List<Control> elements;

        public ControlStack()
        {
            elements = new List<Control>();
        }

        public void Push(Control item)
        {
            elements.Add(item);
        }

        public Control Pop()
        {

            if (elements.Count > 1)
            {

                Control item = elements[elements.Count - 1];
                elements.RemoveAt(elements.Count - 1);
                GC.Collect();
                return item;
            }

            else if (elements.Count == 1)
            {

                return elements[0];
            }

            else
            {
                throw new InvalidOperationException("The stack is empty");
            }

        }


        public Control Peek()
        {
            if (elements.Count > 0)
            {
                return elements[elements.Count - 1];
            }
            else
            {
                throw new InvalidOperationException("The stack is empty");
            }
        }

        public int Count()
        {
            return elements.Count;
        }

        public bool IsEmpty()
        {
            return elements.Count == 0;
        }



        public void Clear()  // in case of pressing home button, the stack will be cleared and then the menu window will be pushed, as the 1st element
        {
            if (elements.Count > 0)
                elements.Clear();
            GC.Collect();
        }


    }
}
