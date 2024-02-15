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
    public partial class RemoveCategory_screen : UserControl
    {
        public RemoveCategory_screen()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckBoxes();
                 int categoryID = int.Parse(CategoryIDTextBox.Text);
               
                
                DatabaseManager dbm = DatabaseManager.GetInstance();

                dbm.DeleteObject("Categories", "ID", categoryID);

                CategoryIDTextBox.Text = "";
                MessageBox.Show($"Category {categoryID} removed sucessfully");
            }

            catch(ArgumentException ex)
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
            if (string.IsNullOrEmpty(CategoryIDTextBox.Text))
            {
                throw new ArgumentException("CategoryID cannot be empty");
            }
            else if(!int.TryParse(CategoryIDTextBox.Text, out int result) )
            {
                throw new ArgumentException("CategoryID must be a number");
            }
            else if (int.Parse(CategoryIDTextBox.Text) < 0)
            {
                throw new ArgumentException("CategoryID cannot be negative");
            }
        }
    }
}
