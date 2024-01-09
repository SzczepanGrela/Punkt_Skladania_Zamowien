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
    public partial class Main_window : Form
    {
        public Main_window()
        {
            InitializeComponent();
            Menu_window mw = new Menu_window();
            mw.TopLevel = false;
            mw.FormBorderStyle = FormBorderStyle.None;
            mw.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(mw);
            mw.Show();
        }


        private Login_window lw; // Var storing if login window was already opened



        private void ReturnButton_Click(object sender, EventArgs e)
        {

        }
        
        private void LogInButton_Click(object sender, EventArgs e)
        {

            if (lw == null || lw.IsDisposed)
            {
                lw = new Login_window();
                lw.Show();
            }
            else
            {
                // If the window is already opened, bring it to front
                lw.BringToFront();
            }
        }

      
    }
}
