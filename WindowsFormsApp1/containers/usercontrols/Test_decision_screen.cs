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
    public partial class Test_decision_screen : BaseUserControl
    {
        List<int> products;
        public Test_decision_screen(List <int> checkedProducts)
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
               
                List<Testing_cart_item_slice> itemsList = Testing_cart_item_slice.createTesting_cart_item_slices(products);
                
                AddSlicestoPanel(itemsList.ToArray(), cartPanel);
            }
            
            
        }
    }
}
