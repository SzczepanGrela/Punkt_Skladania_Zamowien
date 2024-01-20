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

namespace WindowsFormsApp1
{
    public partial class Menu_window : Form
    {
        public Menu_window()
        {
            InitializeComponent();
        }

       

        private void ShopButton_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream:WindowsFormsApp1/forms/Menu_window.cs
            Methods.ChangeWindow(this,  new Shop_window());
=======
            openForm(this, new Shop_form(this), this);


>>>>>>> Stashed changes:WindowsFormsApp1/forms/Menu_form.cs
        }

        private void PresentationButton_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream:WindowsFormsApp1/forms/Menu_window.cs
            Methods.ChangeWindow(this, new Presentation_window());
=======
            openForm(this, new Presentation_form(this),this);
>>>>>>> Stashed changes:WindowsFormsApp1/forms/Menu_form.cs
        }

        private void MatchButton_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream:WindowsFormsApp1/forms/Menu_window.cs
            Methods.ChangeWindow(this, new Match_window());
=======
            openForm(this, new Matching_form(this), this);
>>>>>>> Stashed changes:WindowsFormsApp1/forms/Menu_form.cs
        }


        

       


    }
}
