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
using WindowsFormsApp1.classes.FileOperations;
using WindowsFormsApp1.classes.DataObjects;
using static System.Net.Mime.MediaTypeNames;
using WindowsFormsApp1.containers.usercontrols;

namespace WindowsFormsApp1.controls.usercontrols
{
    public partial class Product_details_screen : BaseUserControl
    {

        DatabaseManager dbm = DatabaseManager.GetInstance();
        bool testscreen;
        int ProductID;


        public Product_details_screen(int ProductID, bool testscreen)
        {
            InitializeComponent();

            query = $"SELECT * FROM Products where ProductID = {ProductID};";
            this.testscreen = testscreen;
            this.ProductID = ProductID;
            this.Load += new EventHandler(Product_details_screen_Load);

        }

        private void Product_details_screen_Load(object sender, EventArgs e)
        {
            this.Size = this.Parent.Size;

            List<Product> products = dbm.ExecuteQuery<Product>(query, Product.MaptoDetail);
           

            

            if (products.Count == 1)
            {
                Product product = products[0];

                if (product.Name != null) nameLabel.Text = product.Name;
                if (product.Description != null) descriptionTextBox.Text = product.Description;
                if (product.Image != null) ProductImage.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(product.Image));

                priceLabel.Text = product.Price.ToString() + "zł";
                if (priceLabel.Text.Length < 8) priceLabel.Text = " " + priceLabel.Text;

                quantity_panel.setPanel(product.StockQuantity);

            }

            else if (products.Count == 0)
            {
                throw new Exception("No products found, even tho it was on the list");
            }

            else
            {
                throw new Exception("Multiple products with same ID");

            }

            if(testscreen)
            {
                this.buyButton.Text = "TEST";
                this.changeButton.Click += new EventHandler(buying);
                this.ChangeOfHeartLabel.Text = "Not sure yet?";
                this.changeButton.Text = "BUY";
                this.buyButton.Click += new EventHandler(testing);

            }
            else
            {
               this.changeButton.Click += new EventHandler(testing);
                this.ChangeOfHeartLabel.Text = "Not sure yet?";
                this.changeButton.Text = "TEST";
                this.buyButton.Click += new EventHandler(buying);
            }
            

        }

        private void buying(object sender, EventArgs e)
        { 
            if(quantity_panel.getQuantity() == 0) return;
            
            localCart.AddToShopping(ProductID, this.quantity_panel.getQuantity());
            if (previousScreens.Peek() is Shopping_cart_screen) return;

            MainPanel_screen.Open(new Shopping_cart_screen());
        }

        private void testing(object sender, EventArgs e)
        {
            localCart.AddToTesting(ProductID);
            if (previousScreens.Peek() is Testing_cart_screen) return;

            MainPanel_screen.Open(new Testing_cart_screen());
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            localCart.AddToTesting(ProductID);
        }

       
    }
}
