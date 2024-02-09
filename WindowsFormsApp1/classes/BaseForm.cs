using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.usercontrols;
using WindowsFormsApp1.interfaces;
using WindowsFormsApp1.controls.forms;
using WindowsFormsApp1.classes;


namespace WindowsFormsApp1.classes
{
    public partial class BaseForm : Form
    {
        protected Control parentContainer;
        public BaseForm()
        {
            InitializeComponent();



            //(this.Width, this.Height) = Resolution.GetWindowRes();
        }

        public void ResetMenu(BaseUserControl MainPanel)   
        {

            MainPanel.Controls.Clear();
     
            Main_window.previousControls.Clear(); // remove all elements from stack

            OpenControl(new Menu_screen(), MainPanel);  // open main menu



        }

        public void OpenForm(Control parentContainer, BaseForm newForm, BaseForm currentForm)    // pattern:  open:| WHERE | WHAT | FORM |you add to stack 
        {
            if (currentForm != null) Main_window.previousControls.Push(currentForm);
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            parentContainer.Controls.Clear();
            parentContainer.Controls.Add(newForm);
            newForm.Show();
        }


        public void OpenControl(Control newControl, Control parentControl)  // open "new" in "parent"
        {
            Main_window.previousControls.Push(newControl);
            newControl.Dock = DockStyle.Fill;
            parentControl.Controls.Clear();
            parentControl.Controls.Add(newControl);
            newControl.Show();
        }

/*
        public void OpenNewControl(Control newControl , Control currentControl)  // open "new" in "parent"; "current" add to  stack
        {
            *//*if (currentControl != null) Main_window.previousControls.Push(currentControl);
            
            newControl.Dock = DockStyle.Fill;
            
            parentContainer.Controls.Clear();
            parentContainer.Controls.Add(newControl);
            newControl.Show();*//*

            throw new NotImplementedException();

        }*/


       


        public DialogResult OpenPopup(Control parentContainer, BasePopup_window newPopup)
        {

           

            newPopup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            newPopup.FormBorderStyle = FormBorderStyle.None;
            newPopup.ControlBox = false;
            newPopup.StartPosition = FormStartPosition.CenterParent;

            newPopup.ShowDialog();

            return newPopup.DialogResult;

        }

    }

}
