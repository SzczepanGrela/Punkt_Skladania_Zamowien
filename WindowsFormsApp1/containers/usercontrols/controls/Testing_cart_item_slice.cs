﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes.DataObjects;
using WindowsFormsApp1.classes.FileOperations;


namespace WindowsFormsApp1.containers.usercontrols.controls
{
    public partial class Testing_cart_item_slice : UserControl
    {
       private CartItem sliceProduct { get; set; }

        public bool checkedState
        {
            get { return this.checkBox.Checked; }
            private set { this.checkBox.Checked = value; }
        }

        public Testing_cart_item_slice()
        {
            InitializeComponent();
        }

        public Testing_cart_item_slice(Product product)
        {
            InitializeComponent();
           this.sliceProduct = new CartItem(product);

            this.Load += Testing_cart_item_slice_Load;
        }

        private void Testing_cart_item_slice_Load(object sender, EventArgs e)
        {
            if(sliceProduct.Image!=null) this.pictureBox1.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(sliceProduct.Image));
            if(sliceProduct.Name!=null) this.nameLabel.Text = sliceProduct.Name;
            this.priceLabel.Text = sliceProduct.Price.ToString() + "zł";
            
        }

        internal static List<Testing_cart_item_slice> createTesting_cart_item_slices(List<CartItem> products)
        {
          

            List<Testing_cart_item_slice> slices = new List<Testing_cart_item_slice>();

            foreach (Product product in products)
            {
                Testing_cart_item_slice slice = new Testing_cart_item_slice(product);
                slices.Add(slice);

            }

            return slices;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            localCart testCart = localCart.GetTestingCart();

            testCart.RemovefromCart(this.sliceProduct);
            this.Dispose();
          
        }

        public CartItem ReturnCartItem()
        {
            return new CartItem(sliceProduct, 1);
        }
    }
}
