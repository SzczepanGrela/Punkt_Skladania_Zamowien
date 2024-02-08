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
using WindowsFormsApp1.classes;
using WindowsFormsApp1.classes.DataObjects;
using WindowsFormsApp1.containers.usercontrols.controls;

namespace WindowsFormsApp1.controls.usercontrols.controls
{
    public partial class Product_button : BaseUserControl
    {
        int ProductID = 0;
        
        BaseUserControl currentScreen = null;
        
        public Product_button()
        {
            InitializeComponent();

            Product_button_load(this,null,"Product Name", "Price");       // default Product in case of mistake of creating empty object   
        }


        public Product_button(string name, byte[] image, int ID, char mode, string price, BaseUserControl currentScreen)
        {
            InitializeComponent();

            

            this.currentScreen = currentScreen;
           
            this.ProductID = ID;
            this.mode = mode;
            this.parentContainer = currentScreen.parentContainer;

            Product_button_load(this, null, name, price, image);


        }

        private void Product_button_load(object sender, EventArgs e, string name, string price, byte[] image = null)
        {

            if (image != null)
            {
                this.pictureBox.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(image));
            }

            nameLabel.Text = name;
            priceLabel.Text = price;

            /*Panel panel = new Panel();

            panel.Parent = this;
            panel.BringToFront();
            panel.Dock = DockStyle.Fill;
            panel.BackColor = Color.Red;
            panel.BringToFront();*/

            AssignClickEventToAllControls(this, new Product_details_screen());


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

            MessageBox.Show("Product ID: " + ProductID.ToString());

           // OpenControl(parentContainer, new Product_details_screen(parentContainer,mode), currentScreen);
        }



        public static List<BaseUserControl> CreateProductButtons(List<Product> products, char mode, BaseUserControl products_screen)
        {
            List<BaseUserControl> productbuttons = new List<BaseUserControl>();
            

            return productbuttons;
        }
    }
}
