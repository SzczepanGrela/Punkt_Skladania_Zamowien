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
    public partial class Testing_cart_screen : BaseUserControl
    {
        private int itemsSelected = 0;
        private List<int> products = localCart.GetTestingItems();
        public Testing_cart_screen()
        {
            InitializeComponent();

            this.Load += new EventHandler(Testing_cart_screen_Load);
        }

        private void Testing_cart_screen_Load(object sender, EventArgs e)
        {
            if (products.Count == 0)
            {
                EmptyCartMessage();
            }

            else
            {
                List<Testing_cart_item_slice> itemsList = Testing_cart_item_slice.createCart_item_slices(products);
                AddSlicestoPanel(itemsList.ToArray(), cartPanel);

                
            }
        }

       

        private void clearButton_Click(object sender, EventArgs e)
        {
            localCart.ClearCart(1);  // 1 is the testing cart
            this.cartPanel.Controls.Clear();          
            EmptyCartMessage();
        }

      

        private void EmptyCartMessage()
        {
            Label label = new Label();
            label.Text = "Your cart is empty";
            label.Font = new Font("Arial", 20);
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            //label.AutoSize = false;
            Panel EmptyCartPanel = new Panel();  // possibly can add a picture here

            label.Size = cartPanel.Size;
            EmptyCartPanel.Size = cartPanel.Size;

            EmptyCartPanel.Controls.Add(label);
            cartPanel.Controls.Add(EmptyCartPanel);
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            MainPanel_screen.Open(new Test_screen());
        }
    }
}
