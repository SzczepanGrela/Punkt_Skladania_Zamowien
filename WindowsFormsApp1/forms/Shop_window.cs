using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Shop_window : Form
    {
        public Shop_window()
        {
            InitializeComponent();
        }

        private void TextBeforeSearch_Click(object sender, EventArgs e)
        {
            SearchBar.Focus();
            TextBeforeSearch.Visible = false;
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
    }
}
