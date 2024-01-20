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
    public partial class Main_window : BaseForm
    {

        
        public Main_window()
        {
            InitializeComponent();

            ResetMenu(MainPanel);
        }

        public static FormStack previousWindows = new FormStack();  // Stack storing previous windows

        private Login_window lw; // Var storing if login window was already opened

       


        private void ReturnButton_Click(object sender, EventArgs e)
        {

            if (previousWindows.Count() > 0)
            {
              
                BaseForm prevForm = previousWindows.Pop(); // Pobierz poprzedni formularz ze stosu
                openForm(prevForm.ParentForm, prevForm);
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
            ResetMenu(MainPanel);
        }

       
    }
}
