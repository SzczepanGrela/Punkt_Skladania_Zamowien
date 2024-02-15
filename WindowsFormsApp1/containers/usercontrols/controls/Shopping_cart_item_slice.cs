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
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1.containers.usercontrols.controls
{
    public partial class Shopping_cart_item_slice : UserControl
    {

        private decimal Price;
        private decimal TotalPrice;
        private int Quantity;

        public int ID { get; private set; }
        public decimal getTotalPrice()
        {
            return this.TotalPrice;
        }

        public int getQuanitity()
        {
            return this.quantity_panel.getQuantity();
        }

        
        public Shopping_cart_item_slice()
        {
            InitializeComponent();


        }


        public Shopping_cart_item_slice(Product product, int quantity)
        {
            InitializeComponent();
            
            this.Price = product.Price;
            this.Quantity = quantity;
            this.TotalPrice = Price * Quantity;
            
            SetCartItem(product.StockQuantity, product.Name, product.Image);
            this.quantity_panel.QuantityChanged += this.OnQuantityChanged;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quantity_panel1_Load(object sender, EventArgs e)
        {
        }

        public void SetCartItem(int inStock, string name, byte[] image)
        {
            
            this.priceLabel.Text = this.TotalPrice.ToString() + "zł";
            if (name != null) this.nameLabel.Text = name;
            if (image != null) this.pictureBox1.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(image));
        }

      
       

        

        public static List<Shopping_cart_item_slice> createCart_item_slices(Dictionary<int, int> productIDsDictionary)
        {
            DatabaseManager dbm = DatabaseManager.GetInstance();


            List<int> IDs = productIDsDictionary.Keys.ToList();


            string query = Querry.ProductsMatchingID(IDs);


            List<Product> products = dbm.ExecuteQuery<Product>(query, Product.MaptoSlice);


             List < Shopping_cart_item_slice> slices =  new List<Shopping_cart_item_slice>();

            foreach (Product product in products)
            {
                int quantity = productIDsDictionary[product.ID];
                Shopping_cart_item_slice slice = new Shopping_cart_item_slice(product, quantity);
                slice.quantity_panel.setPanel(product.StockQuantity, quantity);
               
                slices.Add(slice);
               
            }

            return slices;
        }

      
       
        protected virtual void OnQuantityChanged(object sender, EventArgs e)
        {
            this.Quantity = this.quantity_panel.getQuantity();
            this.TotalPrice = this.Price * this.Quantity;

            this.priceLabel.Text = TotalPrice.ToString() + "zł";

            localCart.GetShoppingCart().UpdateCart(ID, Quantity);
          
            OnPriceChanged(this, EventArgs.Empty);  // poor way of handing over the event to the parent
        }


       public event EventHandler PriceChanged;

        protected virtual void OnPriceChanged(object sender, EventArgs e)
        {
            if (PriceChanged != null)
            {
                PriceChanged(this, EventArgs.Empty);
            }
        }
        

    }




    }
