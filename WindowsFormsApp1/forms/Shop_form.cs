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
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    public partial class Shop_form : BaseForm
    {
        BaseForm parentForm;
        public Shop_form(BaseForm parentForm)
        {
            
            InitializeComponent();

            Methods.LoadImagesAndCreateButtons(this.ButtonPanel, @"..\..\data\images\icons\categories");
            this.parentForm = parentForm;
        }

      

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          openForm(this, new Test_shopping_window(this));

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
