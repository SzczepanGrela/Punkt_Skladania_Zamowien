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
    public partial class Main_window : Form
    {

        
        public Main_window()
        {
            InitializeComponent();


            Methods.HomeButton();
        }

        public static FormStack previousWindows = new FormStack();  // Stack storing previous windows

        private Login_window lw; // Var storing if login window was already opened

       


        private void ReturnButton_Click(object sender, EventArgs e)
        {

            if (previousWindows.Count() > 0)
            {
                Form currentForm = MainPanel.Controls.OfType<Form>().FirstOrDefault(); // Pobierz obecny formularz
                if (currentForm != null)
                {
                    MainPanel.Controls.Remove(currentForm); // Usuń obecny formularz z panelu
                    currentForm.Hide(); // Ukryj obecny formularz
                }

                Form prevForm = Main_window.previousWindows.Pop(); // Pobierz poprzedni formularz ze stosu
                prevForm.Show(); // Pokaż poprzedni formularz
                MainPanel.Controls.Add(prevForm); // Dodaj poprzedni formularz do panelu
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
            Methods.HomeButton();
        }
    }
}
