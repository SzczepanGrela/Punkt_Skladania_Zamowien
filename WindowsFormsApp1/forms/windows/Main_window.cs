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
using WindowsFormsApp1.testowy;



namespace WindowsFormsApp1
{
    public partial class Main_window : BaseForm
    {

        private Panel_form pf; // Var storing panel form, so we can access it and open other forms in it
        public Main_window()
        {
            InitializeComponent();


            this.SetForm(true, null);
            //pf = new Panel_form(MainPanel);

            //ResetMenu(pf);
            var myUserControl = new usercontrol(); // Replace 'MyUserControl' with the actual name of your UserControl

            // Optional: Set properties of the UserControl, if needed
            myUserControl.Dock = DockStyle.Fill; // This will make the UserControl fill the entire Panel

            // Clear the panel before adding new UserControl, if needed
            MainPanel.Controls.Clear();

            // Add the UserControl to the Panel
            MainPanel.Controls.Add(myUserControl);

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

        private void TopBarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
