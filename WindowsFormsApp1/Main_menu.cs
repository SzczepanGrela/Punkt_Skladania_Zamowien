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
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
        }


        private Login_window lw; // Var storing if login window was already opened


        private void button1_Click(object sender, EventArgs e)
        {
            
            Shop_window sw = new Shop_window();
            sw.TopLevel = false;
            sw.FormBorderStyle = FormBorderStyle.None;
            sw.Dock = DockStyle.Fill;

            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(sw);
            sw.Show();
                
                
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

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
                // Możesz tutaj opcjonalnie przenieść istniejące okno na wierzch
                lw.BringToFront();
            }
        }
    }
}
