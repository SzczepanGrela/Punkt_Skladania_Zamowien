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
using WindowsFormsApp1.classes.DataObjects;
using WindowsFormsApp1.classes.FileOperations;
using WindowsFormsApp1.controls.forms;

namespace WindowsFormsApp1.containers.windows
{
    public partial class Popup_window_Register : BasePopup_window
    {
        public Popup_window_Register()
        {
            InitializeComponent();
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {

            bool AllGood = ValidateData();

            if (AllGood)
            {
                try
                {
                    DatabaseManager dbm = DatabaseManager.GetInstance();

                    Person newCustomer = new Customer(NameTextBox.Text, LastNameTextBox.Text, EmailTextBox.Text);

                    int PersonID = dbm.InsertObjectGetID(newCustomer, "Persons", Person.MapPersonToSqlParameters, "ID");

                    

                    newCustomer = new Customer(NameTextBox.Text, LastNameTextBox.Text, LoginTextBox.Text, PasswordTextBox.Text, EmailTextBox.Text, PersonID);

                    dbm.InsertObject((Customer)newCustomer, "Customers", Customer.MapCustomerToSqlParameters);
                    
                    new Popup_window_ok("Registered successfully").OpenPopup();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                
            }
        }


        private bool ValidateData()

        {
            
                if (string.IsNullOrWhiteSpace(LoginTextBox.Text))
                {
                    MessageBox.Show("Login is required.");
                    LoginTextBox.Focus();
                    return false;
                }

          
                if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
                {
                    MessageBox.Show("Password is required.");
                    PasswordTextBox.Focus();
                    return false;
                }

                if (string.IsNullOrWhiteSpace(NameTextBox.Text))
                {
                    MessageBox.Show("Name is required.");
                    NameTextBox.Focus();
                    return false;
                }

               
                if (string.IsNullOrWhiteSpace(LastNameTextBox.Text))
                {
                    MessageBox.Show("Last name is required.");
                    LastNameTextBox.Focus();
                    return false;
                }

               
                if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
                {
                    MessageBox.Show("Email is required.");
                    EmailTextBox.Focus();
                    return false;
                }
                else if (EmailTextBox.Text.Count(c => c=='@') != 1)   // counts how  many cs match the givenn codnditon
                {
                    MessageBox.Show("Email is not valid.");
                    EmailTextBox.Focus();
                    return false;
                }
            return true;

               
            

            

        }
    }
}
