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


namespace WindowsFormsApp1
{
    public partial class Main_window : Form
    {

        
        public Main_window()
        {
            InitializeComponent();


            Methods.ChangeWindow(this.MainPanel, new Menu_window());
        }

        public static Stack<Form> previousWindows = new Stack<Form>();  // Stack storing previous windows

        private Login_window lw; // Var storing if login window was already opened

       


        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Menu_window mw = new Menu_window();
            mw.TopLevel = false;
            mw.FormBorderStyle = FormBorderStyle.None;
            mw.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(mw);
            mw.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
