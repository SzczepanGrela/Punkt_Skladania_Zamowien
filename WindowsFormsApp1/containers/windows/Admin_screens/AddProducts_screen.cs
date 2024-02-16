using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes.DataObjects;
using WindowsFormsApp1.classes.FileOperations;

namespace WindowsFormsApp1.containers.windows.Admin_screens
{
    public partial class AddProducts_screen : UserControl
    {
        private Product productToAdd;

        private string[] columnNames = { "Name",  "Description", "Price", "CategoryID", "StockQuantity" };
        public AddProducts_screen()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DatabaseManager dbm = DatabaseManager.GetInstance();
            try
            {
                CheckBoxes();
                string name = NameTextBox.Text;
                Decimal price = Decimal.Parse(PriceTextBox.Text);   // getting rd off the polish decimal separator  
                string description = DescriptionTextBox.Text;
                int categoryID = int.Parse(CategoryIDTextBox.Text);
                int stockQuantity = int.Parse(StockQuantityTextBox.Text);
                
                productToAdd = new Product(name, price, description, categoryID, stockQuantity);

               dbm.InsertObject(productToAdd, "Products", Product.MapProductToSqlParameters);

                MessageBox.Show($"Product {NameTextBox} added sucessfully");
                ClearBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error ocurrued, try again",ex.Message);
                ClearBoxes();
               
            }
            finally
            {
               
            }




        }

        private void AddProducts_screen_Load(object sender, EventArgs e)
        {

        }

        private void CheckBoxes()
        {
            if(NameTextBox.Text == "" || PriceTextBox.Text == "" || DescriptionTextBox.Text == "" || CategoryIDTextBox.Text == "" || StockQuantityTextBox.Text == "")
            {
                throw new ArgumentException("All fields must be filled");
            }
            if(decimal.TryParse(PriceTextBox.Text.Replace(',','.'), out decimal price))
            {
                throw new ArgumentException("Price must be a number");
            }


            if(!int.TryParse(CategoryIDTextBox.Text, out int ID))
            {
                throw new ArgumentException("CategoryID must be a number");
            }

            if (!int.TryParse(StockQuantityTextBox.Text, out int stockQuantity))
            {
                throw new ArgumentException("StockQuantity must be a number");
            }
            else if(stockQuantity < 0)
            {
                throw new ArgumentException("StockQuantity must be a positive number");
            }

        }



        private void ClearBoxes()
        {

            NameTextBox.Text = "";
            PriceTextBox.Text = "";
            DescriptionTextBox.Text = "";
            CategoryIDTextBox.Text = "";
            StockQuantityTextBox.Text = "";
        }

    }
}
