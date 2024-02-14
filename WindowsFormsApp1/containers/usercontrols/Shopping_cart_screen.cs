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
using WindowsFormsApp1.containers.usercontrols;
using WindowsFormsApp1.containers.usercontrols.controls;

namespace WindowsFormsApp1.controls.usercontrols
{
    public partial class Shopping_cart_screen : BaseUserControl
    {

        private decimal total = 0;
        private Dictionary<int, int> products = localCart.GetShoppingItems();
        public Shopping_cart_screen()
        {
            InitializeComponent();

           
            this.Load += Shopping_cart_screen_Load;

            

        }

        private void Shopping_cart_screen_Load(object sender, EventArgs e)
        {
            

            

            if (products.Count == 0)
            {
               EmptyCartMessage();
                
            }

            else
            {
                List<Cart_item_slice> itemsList = Cart_item_slice.createCart_item_slices(products);
                AddSlicestoPanel(itemsList.ToArray(),cartPanel);

                foreach (Cart_item_slice slice in itemsList)
                {
                    total += slice.getPrice() * slice.getQuanitity();
                    

                    slice.PriceChanged += this.OnPriceChanged;
                }
                priceValueLabel.Text = total.ToString()+"zł";
                
            }

        }

        private void cartPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        protected virtual void OnPriceChanged(object sender, EventArgs e)
        {
            total = 0;
            
            if (cartPanel.Controls.Count == 0)
            {
                this.priceValueLabel.Text = "0zł";
                return;
            }
            foreach (Cart_item_slice slice in cartPanel.Controls)
            {   
               
                total += slice.getPrice() * slice.getQuanitity();
                this.priceValueLabel.Text = total.ToString() + "zł";
            }
        }

        private void continueSearchButton_Click(object sender, EventArgs e)
        {
            MainPanel_screen.Open(new Categories_screen(false));
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (total <= 0) return;
            MainPanel_screen.Open(new Payment_method_screen(total));
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            localCart.ClearCart(0);  // 0 is the shopping cart
            this.cartPanel.Controls.Clear();
            OnPriceChanged(this, new EventArgs());
            EmptyCartMessage();
            

        }


        private void EmptyCartMessage()
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
    }
}
