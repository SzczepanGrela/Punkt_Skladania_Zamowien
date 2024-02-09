using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes;
using WindowsFormsApp1.classes.DataObjects;
using WindowsFormsApp1.classes.FileOperations;
using WindowsFormsApp1.containers.usercontrols.controls;
using WindowsFormsApp1.controls.usercontrols;
using WindowsFormsApp1.controls.usercontrols.controls;

namespace WindowsFormsApp1.controls.usercontrols
{
    public partial class Products_screen : BaseUserControl
    {
        
        DatabaseManager dbm = new DatabaseManager(ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString);
        private int CategoryID;
        public Products_screen(int categoryID): base() 
        {
            InitializeComponent();


            this.CategoryID = categoryID;
            this.Load += new EventHandler(Products_screen_load);
            
            
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Products_screen_load(object sender, EventArgs e)
        {
            query = $"SELECT TOP 20 * FROM Products where CategoryID = {CategoryID} \r\nORDER BY ProductID ASC; \r\n";

            this.Size = this.Parent.Size;

            List<Product> products = dbm.ExecuteQuery<Product>(query, Product.MaptoButton).ToList();

            BaseUserControl[] ProductButtons = Product_button.CreateProductButtons(products, this).ToArray();

       
            
            AddControlstoFlowPanel(ProductButtons, ProductsPanel, 3);

            



        }
    }
}
