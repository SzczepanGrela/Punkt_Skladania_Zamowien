using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using WindowsFormsApp1.classes.DataObjects;
using System.Security.Cryptography.X509Certificates;
using WindowsFormsApp1.classes.Methods;
using WindowsFormsApp1.classes.FileOperations;
using System.Data.Common;

namespace WindowsFormsApp1.containers.usercontrols.controls
{
    public partial class Cart_item_slice : UserControl
    {

        private decimal price;

        public Cart_item_slice()
        {
            InitializeComponent();

            // after any interaction the price should be updated
           // this.quantity_panel.QuantityChanged += new EventHandler(priceLabel_Click);
           

        }


        public Cart_item_slice(int inStock, string name, decimal price, byte[] image, int quantity)
        {
            InitializeComponent();

            this.price = price;
            SetCartItem(inStock, name, price, image, quantity);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quantity_panel1_Load(object sender, EventArgs e)
        {
        }

        public void SetCartItem(int inStock, string name, decimal price, byte[] image, int quantity)
        {

            this.priceLabel.Text = price.ToString() + "zł";
           // this.quantity_panel.setPanel(inStock, quantity);
            if (name != null) this.nameLabel.Text = name;
            if (image != null) this.pictureBox1.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(image));
        }

      
       

        

        public static List<Cart_item_slice> createCart_item_slices(Dictionary<int, int> productIDsDictionary)
        {
            DatabaseManager dbm = DatabaseManager.GetInstance();


            List<int> IDs = productIDsDictionary.Keys.ToList();


            string query = Querry.ProductsMatchingID(IDs);



            


            List<Product> products = dbm.ExecuteQuery<Product>(query, Product.MaptoSlice);

            

             List < Cart_item_slice> slices =  new List<Cart_item_slice>();




            foreach (Product product in products)
            {
                int quantity = productIDsDictionary[product.ID];
                Cart_item_slice slice = new Cart_item_slice(product.StockQuantity, product.Name, product.Price*quantity, product.Image, quantity);
                slice.quantity_panel.setPanel(product.StockQuantity, quantity );
                slices.Add(slice);
            
                    
            }

            return slices;
        }

        private void priceLabel_Click(object sender, EventArgs e)
        {
            
            priceLabel.Text = (price*quantity_panel.getQuantity()).ToString() + "zł";


                
        }
    }
}
