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
    public partial class RemoveProducts_screen : UserControl
    {
        public RemoveProducts_screen()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckBoxes();
                int productID = int.Parse(ProductIDTextBox.Text);

                
                DatabaseManager dbm = DatabaseManager.GetInstance();

                dbm.DeleteObject("Products","ID", productID );

                MessageBox.Show($"Product {productID} removed sucessfully");
                ProductIDTextBox.Text = "";
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
            if(string.IsNullOrEmpty(ProductIDTextBox.Text))
            {
                throw new ArgumentException("ProductID cannot be empty");
            }
            else if(!int.TryParse(ProductIDTextBox.Text, out int result))
            {
                throw new ArgumentException("ProductID must be a number");
            }
            else if(int.Parse(ProductIDTextBox.Text) < 0)
            {
                throw new ArgumentException("ProductID cannot be negative");
            }
        }
    }
}
