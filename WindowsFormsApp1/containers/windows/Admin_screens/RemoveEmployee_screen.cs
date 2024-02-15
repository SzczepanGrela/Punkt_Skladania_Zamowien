using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes.FileOperations;

namespace WindowsFormsApp1.containers.windows.Admin_screens
{
    public partial class RemoveEmployee_screen : UserControl
    {
        public RemoveEmployee_screen()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckBoxes();

                int employeeID = int.Parse(EmployeeIDTextBox.Text);

                DatabaseManager dbm = DatabaseManager.GetInstance();

                dbm.DeleteObject("Employees", "ID", employeeID);


            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured, try again");
            }
            finally
            {

            }
        }

        private void CheckBoxes()
        {
            if (string.IsNullOrEmpty(EmployeeIDTextBox.Text))
            {
                throw new ArgumentException("EmployeeID cannot be empty");
            }
            else if(!int.TryParse(EmployeeIDTextBox.Text, out int result))
            {
                throw new ArgumentException("EmployeeID must be a number");
            }
            else if(int.Parse(EmployeeIDTextBox.Text) < 0)
            {
                throw new ArgumentException("EmployeeID cannot be negative");
            }
        }
    }
}
