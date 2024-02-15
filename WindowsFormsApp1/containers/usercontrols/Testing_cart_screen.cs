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
using WindowsFormsApp1.controls.forms;
using WindowsFormsApp1.controls.usercontrols.controls;

namespace WindowsFormsApp1.controls.usercontrols
{
    public partial class Testing_cart_screen : BaseUserControl
    {

        private List<int> products = localCart.GetTestingCart().GetProducts().Keys.ToList();
        private List<int> checkedProducts = new List<int>();

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
                List<Testing_cart_item_slice> itemsList = Testing_cart_item_slice.createTesting_cart_item_slices(products);
                AddSlicestoPanel(itemsList.ToArray(), cartPanel);


            }
        }



        private void clearButton_Click(object sender, EventArgs e)
        {
            localCart.GetTestingCart().ClearCart();  // 1 is the testing cart
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



        private void continueSearchButton_Click(object sender, EventArgs e)
        {
            MainPanel_screen.Open(new Categories_screen(true));
        }

        private void orderTestButton_Click(object sender, EventArgs e)
        {
            int selecteditems = CountChecked();
            if (selecteditems == 0) return;
            else if (selecteditems > 3)
            {
                OpenPopup(new Popup_window_ok("You can only order 3 tests at a time"));

                return;
            }
            else  // under 3 items, test order can be placed
            {
                // inFuture add communication with the server

                

                BasePopup_window popup = new Popup_window_ok("Order confirmed\nPlease wait for our Employee");
                popup.OpenPopup();

                if (popup.DialogResult == DialogResult.OK)
                {
                    EmployeeLogin();
                }
              
            }

        }


        private void EmployeeLogin()
        {

            Popup_window_EmployeeLogin popup = new Popup_window_EmployeeLogin();
            popup.OpenPopup();
            if (popup.DialogResult == DialogResult.OK)
            {
                MainPanel_screen.Open(new Test_decision_screen(checkedProducts));
            }
        }


        private int CountChecked()
        {
            int itemsSelected = 0;
            checkedProducts.Clear();
            foreach(Testing_cart_item_slice slice in cartPanel.Controls)
            {
                if (slice.checkedState)
                {
                    itemsSelected++;
                    checkedProducts.Add(slice.ID);

                }
            }
           return itemsSelected;
        }



       
    }

}
