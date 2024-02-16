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
using WindowsFormsApp1.controls.forms;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp1.controls.usercontrols
{
    public partial class Product_details_screen : BaseUserControl
    {

        DatabaseManager dbm = DatabaseManager.GetInstance();
        bool testscreen;
        int ProductID;

        Product product;

        public Product_details_screen(int ProductID, bool testscreen)
        {
            InitializeComponent();

            
            this.testscreen = testscreen;
            this.ProductID = ProductID;
            this.Load += new EventHandler(Product_details_screen_Load);

        }

        private void Product_details_screen_Load(object sender, EventArgs e)
        {
            this.Size = this.Parent.Size;

            query = $"SELECT * FROM Products where ID = {ProductID};";

            List<Product> products = dbm.ExecuteQuery<Product>(query, Product.MaptoDetail);
           

            

            if (products.Count == 1)
            {
                this.product = products[0];

                if (product.Name != null) nameLabel.Text = product.Name;
                if (product.Description != null) descriptionTextBox.Text = product.Description;
                if (product.Image != null) ProductImage.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(product.Image));

                priceLabel.Text = product.Price.ToString() + "zł";
                if (priceLabel.Text.Length < 8) priceLabel.Text = " " + priceLabel.Text;

                quantity_panel.SetPanel(product.StockQuantity);

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
                
                this.ChangeOfHeartLabel.Text = "Not sure yet?";
                this.changeButton.Text = "BUY";
                this.buyButton.Click += new EventHandler(Testing);
                

            }
            else
            {
               this.changeButton.Click += new EventHandler(Testing);
                this.ChangeOfHeartLabel.Text = "Not sure yet?";
                this.changeButton.Text = "TEST";
                this.buyButton.Click += new EventHandler(Buying);
            }
            

        }

        private void Buying(object sender, EventArgs e)
        {
            int quantity = quantity_panel.GetQuantity();

            if (quantity_panel.GetQuantity() == 0 || product.StockQuantity <1) return;

            
             
            localCart.GetShoppingCart().AddtoCart(this.product, quantity);

            if (previousScreens.Peek() is Shopping_cart_screen) return;

            else MainPanel_screen.Open(new Shopping_cart_screen());
        }

        private void Testing(object sender, EventArgs e)
        {
            localCart.GetTestingCart().AddtoCart(product, 1);
            if (previousScreens.Peek() is Testing_cart_screen) return;

            MainPanel_screen.Open(new Testing_cart_screen());
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            if (quantity_panel.GetQuantity() == 0) return;  // prevention rfom adding 0 items to the cart

            if (testscreen)
            {
                localCart.GetTestingCart().AddtoCart(product, quantity_panel.GetQuantity());
                Popup_window_ok popup = new Popup_window_ok("Item added to the test cart");
                popup.OpenPopup();
               
            }
            else
            {
                localCart.GetShoppingCart().AddtoCart(product, quantity_panel.GetQuantity());
                Popup_window_ok popup = new Popup_window_ok("Item added to the shopping cart");
                popup.OpenPopup();
                
            }

        }

        private void changeButton_Click(object sender, EventArgs e)
        {

            if (testscreen)
            {
                Popup_window_yn popup = new Popup_window_yn($"Are you sure you want to buy it?\nThe price is:{priceLabel.Text}");
                popup.OpenPopup();
                if(popup.DialogResult == DialogResult.Yes)
                {
                   Buying(this, EventArgs.Empty);
                }

            }
            else
            {
                Popup_window_yn popup = new Popup_window_yn($"You're about to enter Test Cart.\nDo you want to preceed?");
                popup.OpenPopup();
                if (popup.DialogResult == DialogResult.Yes)
                {
                    Testing(this, EventArgs.Empty);
                }
            }

        }

        public Product ReturnProduct()
        {
            return product;
        }
    }
}
