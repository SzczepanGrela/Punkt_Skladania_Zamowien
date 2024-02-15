using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApp1.classes;
using WindowsFormsApp1.classes.FileOperations;
using WindowsFormsApp1.classes.DataObjects;
using WindowsFormsApp1.controls.forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Popup_window_EmployeeLogin : BasePopup_window
    {
        

        public Popup_window_EmployeeLogin()
        {
            InitializeComponent();
            
            this.BackColor = base.BackColor;
        }

        private void login_window_Load(object sender, EventArgs e)
        {

        }

      

        private void leaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            DatabaseManager dbm = DatabaseManager.GetInstance();

            string CardID = CardIDTextbox.Text;

            string query = $"SELECT Count(*) FROM Employees WHERE CardID = '{CardID}'";

             int count = dbm.CountRecords(query);

            if (count == 1)
            {
               
                this.Hide();
                this.DialogResult = DialogResult.OK;
                this.Close();
                
               
            }
            else if (count > 1)
            {
                throw new Exception("More than one employee with the same card ID");
            }
            else
            {
                new Popup_window_ok("CardID incorrect.");
            }   
        }
    }
}
