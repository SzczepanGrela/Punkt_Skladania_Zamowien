using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.controls.forms;
using WindowsFormsApp1.interfaces;
using WindowsFormsApp1.usercontrols;

namespace WindowsFormsApp1.classes
{
    public partial class BaseUserControl : UserControl, IContainerControlOperations
    {
        public Control parentContainer = null;

        protected char mode = ' ';


        public BaseUserControl()
        {
            InitializeComponent();
        }
        public BaseUserControl(Control parentContainer, char mode)
        {
            InitializeComponent();
            this.parentContainer = parentContainer;
            this.mode = mode;
        }

        public void ResetMenu(Control parentContainer)
        {


            OpenControl(parentContainer, new usercontrols.Menu_screen(parentContainer, ' '), null);
            Main_window.previousControls.Clear(); // remove all elements from stack

        }



        public void OpenControl(Control parentContainer, Control newControl, Control currentControl)  // open "new" in "parent"; "current" add to  stack
        {
            if (currentControl != null) Main_window.previousControls.Push(currentControl);

            newControl.Dock = DockStyle.Fill;

            parentContainer.Controls.Clear();
            parentContainer.Controls.Add(newControl);
            newControl.Show();

        }


        public DialogResult OpenPopup(Control parentContainer, BasePopup_window newPopup) 
        {
          
            newPopup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            
            newPopup.ShowDialog();

            return newPopup.DialogResult;

        }




    }
}
