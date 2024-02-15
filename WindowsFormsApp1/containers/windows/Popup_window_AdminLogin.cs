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
using WindowsFormsApp1.classes.FileOperations;

namespace WindowsFormsApp1.containers.windows
{
    public partial class Popup_window_AdminLogin : BasePopup_window
    {
        public Popup_window_AdminLogin()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            DatabaseManager dbm = DatabaseManager.GetInstance();
            string EnteredCode = CardIDTextbox.Text;
            string EnteredPassword = PasswordTextbox.Text;

            int count = dbm.CountRecords($"SELECT Count(*) FROM Employees WHERE CardID = '{EnteredCode}' AND Password = '{EnteredPassword}' and Position = 'Manager'");

            if (count == 1)
            {
                this.Close();
                Admin_window admin_Window = new Admin_window();
                admin_Window.Show();
                admin_Window.TopMost = true;
                
                
                
                
            }
            
        }
    }
}
