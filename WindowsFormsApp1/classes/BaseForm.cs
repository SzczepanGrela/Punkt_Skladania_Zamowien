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
using WindowsFormsApp1.forms;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1.classes
{
    public partial class BaseForm : Form
    {
        protected Control parentContainer;
        public BaseForm()
        {
            InitializeComponent();

            (this.Width, this.Height) = Resolution.GetWindowRes();
        }

        protected void ResetMenu(BaseForm form)   // |where|what|
        {
            parentContainer = form.parentContainer;
            openForm(parentContainer, form, null);
            openForm(form, new MenuForm(form), null);
            Main_window.previousForms.Clear(); // remove all elements from stack

        }

        protected void openForm(Control parentContainer, BaseForm newForm, BaseForm currentForm)   // open form in panel or other container (like form)
                                                                                                   // pattern:  open:| WHERE | WHAT | FORM |you add to stack  

        {
            if (currentForm != null) Main_window.previousForms.Push(currentForm);
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            parentContainer.Controls.Clear();
            parentContainer.Controls.Add(newForm);
            newForm.Show();
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
