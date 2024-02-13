using System;
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
using WindowsFormsApp1.containers.usercontrols.controls;

namespace WindowsFormsApp1.controls.usercontrols
{
    public partial class Shopping_cart_screen : BaseUserControl
    {
        
        public Shopping_cart_screen()
        {
            InitializeComponent();

            this.Load += Shopping_cart_screen_Load;


        }

        private void Shopping_cart_screen_Load(object sender, EventArgs e)
        {
            Dictionary<int, int> products = localCart.GetItems();



            if (products.Count == 0)
            {
                Label label = new Label();
                label.Text = "Your cart is empty";
                label.Font = new Font("Arial", 20);
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.AutoSize = false;
                Panel EmptyCartPanel = new Panel();  // possibly can add a picture here
               
                label.Size = cartPanel.Size;
                EmptyCartPanel.Size = cartPanel.Size;

                EmptyCartPanel.Controls.Add(label);
                cartPanel.Controls.Add(EmptyCartPanel);

                
            }

            else
            {
                List<Cart_item_slice> itemsList = Cart_item_slice.createCart_item_slices(products);
                AddSlicestoFlowPanel(itemsList.ToArray(),cartPanel);
               
            }

        }
    }
}
