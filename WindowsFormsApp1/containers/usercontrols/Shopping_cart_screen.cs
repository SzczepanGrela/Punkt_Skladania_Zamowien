﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes;
using WindowsFormsApp1.classes.DataObjects;
using WindowsFormsApp1.containers.usercontrols;
using WindowsFormsApp1.containers.usercontrols.controls;
using WindowsFormsApp1.controls.forms;

namespace WindowsFormsApp1.controls.usercontrols
{
    public partial class Shopping_cart_screen : BaseScreen
    {

        private decimal total;
        private Dictionary<int, CartItem> CartITems = localCart.GetShoppingCart().GetProducts();
        public Shopping_cart_screen()
        {
            InitializeComponent();

            CartItem.UpdateItemsinDB();

            this.Load += Shopping_cart_screen_Load;


        }

        private void Shopping_cart_screen_Load(object sender, EventArgs e)
        {
            
            if (CartITems.Count == 0)
            {
               EmptyCartMessage();
                
            }

            else
            {
                List<Shopping_cart_item_slice> itemsList = Shopping_cart_item_slice.createCart_item_slices(CartITems);
                AddSlicestoPanel(itemsList.ToArray(),cartPanel);

                foreach (Shopping_cart_item_slice slice in itemsList)
                {
                    total += slice.GetTotalPrice();
                    
                    slice.PriceChanged += this.OnPriceChanged;
                }
                priceValueLabel.Text = total.ToString()+"zł";
                
            }

        }

   


        protected virtual void OnPriceChanged(object sender, EventArgs e)
        {
            total = 0;

            if (cartPanel.Controls.Count == 0)
            {
                this.priceValueLabel.Text = "0zł";
                return;
            }
            else
            {
                foreach (Shopping_cart_item_slice slice in cartPanel.Controls)
                {

                    total += slice.GetTotalPrice();

                }
                this.priceValueLabel.Text = total.ToString() + "zł";
            }
        }

        private void continueSearchButton_Click(object sender, EventArgs e)
        {
            Main_window.ResetMenu();
            MainPanel_screen.Open(new Categories_screen(false));
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (total <= 0) return;
            CartItem.UpdateItemsinDB();
            MainPanel_screen.Open(new Payment_method_screen(total));
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Popup_window_ok popup = new Popup_window_ok("Are you sure you want to clear your cart?");

            popup.OpenPopup();
            if (popup.DialogResult == DialogResult.OK)
            {
                localCart.GetShoppingCart().ClearCart();  
                this.cartPanel.Controls.Clear();
                OnPriceChanged(this, new EventArgs());
                EmptyCartMessage();
            }

            
            

        }


        private void EmptyCartMessage()
        {

            Label label = new Label
            {
                Text = "Your cart is empty",
                Font = new Font("Arial", 20),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Size = cartPanel.Size // Zakładam, że 'cartPanel' to istniejąca kontrolka, z której pobierasz rozmiar
            };



            Panel EmptyCartPanel = new Panel { Size = cartPanel.Size };  // possibly can add a picture her later

            
            EmptyCartPanel.Controls.Add(label);
            cartPanel.Controls.Add(EmptyCartPanel);
        }

       

        private void payButton_Click_1(object sender, EventArgs e)
        {
            if (total <= 0) OpenPopup(new Popup_window_ok("Pick at least one item."));
            else
           
            MainPanel_screen.Open(new Payment_method_screen(total));
        }

        

    }



}
