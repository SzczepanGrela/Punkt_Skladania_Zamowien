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
using WindowsFormsApp1.controls.usercontrols.controls;

namespace WindowsFormsApp1.controls.usercontrols
{
    public partial class Products_screen : BaseScreen
    {
        DatabaseManager dbm = DatabaseManager.GetInstance("TwojeConnectionString");

        private int CategoryID;
        private bool Testable { get; set; }
        public Products_screen(int categoryID, bool Testable) 
        {
            InitializeComponent();


            this.CategoryID = categoryID;
            this.Testable = Testable;
            this.Load += new EventHandler(Products_screen_load);
            

        }

       

        private void Products_screen_load(object sender, EventArgs e)
        {
            query = $"SELECT TOP 20 * FROM Products where CategoryID = {CategoryID} \r\nORDER BY ID ASC; \r\n";


            List<Product> products = dbm.ExecuteQuery<Product>(query, Product.MaptoButton);

            UserControl[] ProductButtons = Product_button.CreateProductButtons(products, Testable).ToArray();

       
            
            AddButtonstoFlowPanel(ProductButtons, ProductsPanel, 3);

            



        }
    }
}
