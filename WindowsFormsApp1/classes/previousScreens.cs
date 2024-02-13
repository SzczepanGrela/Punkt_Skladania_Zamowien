using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1.classes
{
    public static class previousScreens   // stack of user controls, forms and other containers
    {
        private static List<Control> elements = new List<Control>();

        public static void Push(Control item)
        {
            elements.Add(item);
        }

        public static Control Pop()
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


        public static Control Peek()
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

        public static int Count()
        {
            return elements.Count;
        }

        public static bool IsEmpty()
        {
            return elements.Count == 0;
        }



        public static void Clear()  // in case of pressing home button, the stack will be cleared and then the menu window will be pushed, as the 1st element
        {
            if (elements.Count > 0)
                elements.Clear();
            GC.Collect();
        }


        

    }
}
