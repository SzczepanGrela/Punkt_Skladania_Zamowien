using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes.DataObjects;
using WindowsFormsApp1.classes.FileOperations;


namespace WindowsFormsApp1.containers.windows.Admin_screens
{
    public partial class AddEmployee_screen : UserControl
    {

        enum Positions
        {
            
            FloorEmployee,
            Cashier,
            Warehouse
        }

        
        public AddEmployee_screen()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Person employeeToAdd = new Employee();
            try
            {

                checkBoxes();

                string name = NameTextBox.Text;
                string lastname = LastnameTextBox.Text;
                string contact = ContactTextBox.Text;
                string cardID = CardIDTextBox.Text;
                string password = PasswordTextBox.Text;
                string position = PositionTextBox.Text;



                employeeToAdd = new Employee(name, lastname, contact);

                DatabaseManager dbm = DatabaseManager.GetInstance();

                int insertedPersonID=dbm.InsertObjectGetID(employeeToAdd, "Persons", Person.MapPersonToSqlParameters);

                employeeToAdd = new Employee(name, lastname, contact, cardID, password, position, insertedPersonID);

                dbm.InsertObject((Employee)employeeToAdd, "Employees", Employee.MapEmployeeToSqlParameters);

                MessageBox.Show($"Employee {NameTextBox} added sucessfully");

                ClearAllBoxes();

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception )
            {
                MessageBox.Show("An error occured, try again");
                ClearAllBoxes();
            }
            
            finally
            {
                
            }


        }

        private void checkBoxes()
        {

            

            if (string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(LastnameTextBox.Text) || string.IsNullOrEmpty(ContactTextBox.Text) || string.IsNullOrEmpty(CardIDTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text) || string.IsNullOrEmpty(PositionTextBox.Text))
            {
                throw new ArgumentException("All fields must be filled");
            }
            if (ContactTextBox.Text.Count(c => c == '@') != 1)
            {
                ContactTextBox.Text = "";
                throw new ArgumentException("Invalid email");
            }
            if (!Enum.TryParse(PositionTextBox.Text.Replace(" ", ""),out Positions position))
            {
                PositionTextBox.Text = "";
                throw new ArgumentException("Invalid position");    
            }
            if (CardIDTextBox.Text.Length != 6)
            {
                this.PositionTextBox.Text = "";
                throw new ArgumentException("CardID must be 6 characters long");
            }
            if (PasswordTextBox.Text.Length < 5)
            {
                this.PasswordTextBox.Text = "";
                throw new ArgumentException("Password must be at least 5 characters long");
            }



            



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void ClearAllBoxes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }
        }

       
    }
}
