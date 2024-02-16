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

using WindowsFormsApp1.classes.FileOperations;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1.containers.usercontrols.controls
{
    public partial class Shopping_cart_item_slice : UserControl
    {
        private CartItem sliceProduct;
        

        public int ID { get; private set; }
        public decimal getTotalPrice()
        {
            return getQuanitity() * sliceProduct.Price;
        }

        public int getQuanitity()
        {
            return this.quantity_panel.getQuantity();
        }

        
        public Shopping_cart_item_slice()
        {
            InitializeComponent();


        }


        public Shopping_cart_item_slice(Product product, int quantity) : this(new CartItem(product, quantity)){}

        public Shopping_cart_item_slice(CartItem product)
        {
            InitializeComponent();
            
            this.sliceProduct = product;
            SetCartItem();
            this.quantity_panel.QuantityChanged += this.OnQuantityChanged;
        }



       

       

        public void SetCartItem()
        {
            
            this.priceLabel.Text = (this.sliceProduct.Price * this.sliceProduct.Quantity) + "zł";
            if (sliceProduct.Name != null) this.nameLabel.Text = sliceProduct.Name;
 
            if (sliceProduct.Image != null) this.pictureBox1.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(sliceProduct.Image));


        }

      
       

        

        public static List<Shopping_cart_item_slice> createCart_item_slices(Dictionary<int, CartItem> CartList)
        {
            

            


            List<CartItem> Items =  CartList.Values.ToList();
            


             List <Shopping_cart_item_slice> slices =  new List<Shopping_cart_item_slice>();

            foreach (CartItem product in Items)
            {
                
                Shopping_cart_item_slice slice = new Shopping_cart_item_slice(product);
                slice.quantity_panel.setPanel(product.StockQuantity, product.Quantity);
               
                slices.Add(slice);
               
            }

            return slices;
        }

      
       
        protected virtual void OnQuantityChanged(object sender, EventArgs e)
        {
            
            sliceProduct.newQuantity(getQuanitity());

            decimal TotalPrice = sliceProduct.TotalPrice;

            this.priceLabel.Text = TotalPrice.ToString() + "zł";

            localCart.GetShoppingCart().UpdateCart(sliceProduct);
          
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




        public CartItem returnCartItem()
        {
            return sliceProduct;
        }
        

    }




    }
