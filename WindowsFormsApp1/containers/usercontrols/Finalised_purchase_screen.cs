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



namespace WindowsFormsApp1.controls.usercontrols
{
    public partial class Finalised_purchase_screen : BaseScreen
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
