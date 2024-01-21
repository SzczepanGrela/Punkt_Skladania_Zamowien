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
    public partial class MenuForm : BaseForm
    {
        

        public MenuForm(Control parentContainer)
        {
            InitializeComponent();
            this.SetForm(false, parentContainer);
            
            

        }



        private void ShopButton_Click(object sender, EventArgs e)
        {
            openForm(parentContainer, new Shop_form(parentContainer), this);


        }

        private void PresentationButton_Click(object sender, EventArgs e)
        {
            openForm(parentContainer, new Presentation_form(parentContainer), this);
        }

        private void MatchButton_Click(object sender, EventArgs e)
        {
            openForm(parentContainer, new Matching_form(parentContainer), this);
        }







    }
}
