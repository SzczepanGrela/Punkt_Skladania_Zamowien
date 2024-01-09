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
    public partial class Menu_window : Form
    {
        public Menu_window()
        {
            InitializeComponent();
        }

        private void ShopButton_Click(object sender, EventArgs e)
        {
            Shop_window sw = new Shop_window();
            sw.TopLevel = false;
            sw.FormBorderStyle = FormBorderStyle.None;
            sw.Dock = DockStyle.Fill;
            this.MenuPanel.Controls.Clear();
            this.MenuPanel.Controls.Add(sw);
            sw.Show();
        }

        
    }
}
