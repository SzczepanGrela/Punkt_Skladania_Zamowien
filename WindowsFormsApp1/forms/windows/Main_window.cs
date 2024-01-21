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
using WindowsFormsApp1.forms;
using WindowsFormsApp1.Forms;



namespace WindowsFormsApp1
{
    public partial class Main_window : BaseForm
    {

        private Panel_form pf; // Var storing panel form, so we can access it and open other forms in it
        public Main_window()
        {
            InitializeComponent();
            this.setResolution(true);                // Set window size
            pf = new Panel_form(MainPanel);
            ResetMenu(pf);
        }

        public static FormStack previousForms = new FormStack();  // Stack storing previous windows

        private Login_window lw; // Var storing if login window was already opened




        private void ReturnButton_Click(object sender, EventArgs e)
        {

            if (previousForms.Count() > 0)
            {

                BaseForm prevForm = previousForms.Pop();
                openForm(pf, prevForm, null); // open prev form, without adding current one to stack
            }


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

        private void HomeButton_Click(object sender, EventArgs e)
        {
            ResetMenu(pf);
        }


    }
}
