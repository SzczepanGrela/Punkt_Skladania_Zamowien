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
        private BaseForm parentForm;

        public MenuForm(BaseForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            
        }

       

        private void ShopButton_Click(object sender, EventArgs e)
        {
            openForm(this, new Shop_form(this), this);


        }

        private void PresentationButton_Click(object sender, EventArgs e)
        {
            openForm(this, new Presentation_form(this),this);
        }

        private void MatchButton_Click(object sender, EventArgs e)
        {
            openForm(this, new Matching_form(this), this);
        }


        

       


    }
}
