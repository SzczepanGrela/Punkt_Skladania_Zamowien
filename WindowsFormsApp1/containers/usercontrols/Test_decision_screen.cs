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
using WindowsFormsApp1.controls.usercontrols;
using WindowsFormsApp1.usercontrols;


namespace WindowsFormsApp1.controls.usercontrols
{
    public partial class Test_decision_screen : BaseUserControl
    {
        List<Testing_cart_item_slice> products;
        public Test_decision_screen(List <Testing_cart_item_slice> checkedProducts)
        {
            InitializeComponent();

            this.products = checkedProducts;
            this.Load += Test_decision_screen_Load;
        }
        private void Test_decision_screen_Load(object sender, EventArgs e)
        {
            
            if (products.Count == 0)
            {
                throw new Exception("No items in the testing cart");
            }
            else
            {
               
                AddSlicestoPanel(products.ToArray(), cartPanel);
            }
            
            
        }

        private void ResetAllButton_Click(object sender, EventArgs e)
        {
            previousScreens.Clear();
            MainPanel_screen.Open(new Menu_screen());
            localCart.ClearCarts(); //clears both carts

        }

        private void buySelectedButton_Click(object sender, EventArgs e)
        {
            foreach (Testing_cart_item_slice testSlice in products)
            {
                CartItem sliceToItem = testSlice.ReturnCartItem();

                localCart cart = localCart.GetTestingCart();

                cart.RemovefromCart(sliceToItem);
                
                cart = localCart.GetShoppingCart();

                cart.AddtoCart(sliceToItem);

                
                
                
            }

            MainPanel_screen.Open(new Shopping_cart_screen());
        }
    }
}
