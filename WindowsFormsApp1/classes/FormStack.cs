using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1.classes
{
    public class FormStack
    {
        private List<BaseForm> elements;

        public FormStack()
        {
            elements = new List<BaseForm>();
        }

        public void Push(BaseForm item)
        {
            elements.Add(item);
        }

        public BaseForm Pop()
        {


            if (elements.Count > 1)
            {

                BaseForm item = elements[elements.Count - 1];
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


        public Form Peek()
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
