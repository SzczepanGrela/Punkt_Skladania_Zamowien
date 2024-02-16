using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes;
using WindowsFormsApp1.classes.DataObjects;
using WindowsFormsApp1.classes.FileOperations;
using WindowsFormsApp1.containers.usercontrols;
using WindowsFormsApp1.containers.usercontrols.controls;
using WindowsFormsApp1.controls.forms;
using WindowsFormsApp1.controls.usercontrols;
using WindowsFormsApp1.usercontrols;


namespace WindowsFormsApp1.controls.usercontrols
{
    public partial class Finalised_purchase_screen : BaseUserControl
    {
        public Finalised_purchase_screen() 
        {
            InitializeComponent();
        }

        private void returnMainButton_Click(object sender, EventArgs e)
        {
            localCart.ClearCarts();  // Clear both carts
            Main_window.ResetMenu();

        }

     
    }
}
