using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes;
using WindowsFormsApp1.usercontrols;

namespace WindowsFormsApp1.interfaces
{
    internal interface IContainerControlOperations
    {

        void ResetMenu(Control parentContainer);


        void openForm(Control parentContainer, BaseForm newForm, BaseForm currentForm);


        void openControl(Control parentContainer, Control newControl, Control currentControl);

       
    }
}

