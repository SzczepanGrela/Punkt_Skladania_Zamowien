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
using WindowsFormsApp1.containers.usercontrols;


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

        public static void ResetMenu()   
        {
            MainPanel_screen.getInstance().Controls.Clear();
            
            previousScreens.Clear(); // remove all elements from stack

            MainPanel_screen.Open(new Menu_screen());  // open main menu

        }


    }

}
