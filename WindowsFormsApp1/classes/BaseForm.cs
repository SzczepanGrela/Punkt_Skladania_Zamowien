using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.usercontrols;
using WindowsFormsApp1.interfaces;


namespace WindowsFormsApp1.classes
{
    public abstract partial class BaseForm : Form, IContainerControlOperations
    {
        protected Control parentContainer;
        public BaseForm()
        {
            InitializeComponent();

            //(this.Width, this.Height) = Resolution.GetWindowRes();
        }

        public void ResetMenu(Control parentContainer)   
        {
            
            
            openControl(parentContainer, new Menu_control(parentContainer), null);
            Main_window.previousControls.Clear(); // remove all elements from stack

        }

        public void openForm(Control parentContainer, BaseForm newForm, BaseForm currentForm)    // pattern:  open:| WHERE | WHAT | FORM |you add to stack 
        {
            if (currentForm != null) Main_window.previousControls.Push(currentForm);
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            parentContainer.Controls.Clear();
            parentContainer.Controls.Add(newForm);
            newForm.Show();
        }


        public void openControl(Control parentContainer, Control newControl , Control currentControl)  // open "new" in "parent"; "current" add to  stack
        {
            if (currentControl != null) Main_window.previousControls.Push(currentControl);
            
            newControl.Dock = DockStyle.Fill;
            
            parentContainer.Controls.Clear();
            parentContainer.Controls.Add(newControl);
            newControl.Show();

        }


        public void SetForm(bool isWindow, Control parentContainer)   // set form size and parent container
        {
           /* if (isWindow)
            {
                (this.Width, this.Height) = Resolution.GetWindowRes();
            }
            else
            {
                (this.Width, this.Height) = Resolution.GetFormRes();
            }*/

            this.parentContainer = parentContainer;

        }

    }

}
