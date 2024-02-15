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
    public partial class AddCategory_screen : UserControl
    {
        Category categorytoAdd;

       
        public AddCategory_screen()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckBoxes();

                categorytoAdd = new Category(NameTextBox.Text, TestableCheckBox.Checked);

                DatabaseManager dbm = DatabaseManager.GetInstance();

                int insertedID = dbm.InsertObjectGetID(categorytoAdd, "Categories", Category.MapCategoryToSqlParameters);


                MessageBox.Show($"Category {NameTextBox.Text} added sucessfully");



                NameTextBox.Text = NameTextBox.Text = "";
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
            if(string.IsNullOrEmpty(NameTextBox.Text))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
