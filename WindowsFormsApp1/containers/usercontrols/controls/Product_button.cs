using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.classes;
using WindowsFormsApp1.classes.DataObjects;
using WindowsFormsApp1.containers.usercontrols.controls;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1.controls.usercontrols.controls
{
    public partial class Product_button : UserControl
    {
        int ProductID = 0;

        BaseUserControl currentScreen = null;

        public Product_button()
        {
            InitializeComponent();



            this.nameLabel.Text = "Product Name";  // default Product in case of mistake of creating empty object  
            this.priceLabel.Text = "Price";



            this.Load += new EventHandler(Product_button_load);

        }


        public Product_button(string name, byte[] image, int ID, string price, BaseUserControl currentScreen)
        {
            InitializeComponent();



            this.currentScreen = currentScreen;


            

            if (image != null) this.pictureBox.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(image));

            if (name != null) nameLabel.Text = name;

            if (price != null) priceLabel.Text = price;

            this.ProductID = ID;

            this.Parent = currentScreen.Parent;

            this.Load += new EventHandler(Product_button_load);





        }

        private void Product_button_load(object sender, EventArgs e)
        {



            this.pictureBox.Click += new EventHandler(ProductButton_Click);

        }

        private void Item_view_load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void priceLabel_Click(object sender, EventArgs e)
        {

        }




        public void ProductButton_Click(object sender, EventArgs e)
        {

            

            currentScreen.OpenNewControl(new Product_details_screen(ProductID,false), currentScreen);
        }



        public static List<UserControl> CreateProductButtons(List<Product> products, BaseUserControl products_screen)
        {
            List<UserControl> productbuttons = new List<UserControl>();
            foreach (Product product in products)
            {

                Product_button productbutton = new Product_button(product.Name, product.Image, product.ID, product.Price.ToString(), products_screen);


                foreach (Control control in Methods.AllcontrolstoList(productbutton))     // adding event to all controls
                {
                    control.Click += new EventHandler(productbutton.ProductButton_Click);
                }

                productbuttons.Add(productbutton);
            }

            return productbuttons;
        }





    }
}
