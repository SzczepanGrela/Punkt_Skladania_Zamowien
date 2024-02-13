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
using WindowsFormsApp1.classes.FileOperations;

namespace WindowsFormsApp1.controls.usercontrols
{
    public partial class Payment_method_screen : BaseUserControl
    {
        decimal totalPrice;

        

        DatabaseManager dbm = DatabaseManager.GetInstance();
        public Payment_method_screen(decimal totalPrice)
        {
            InitializeComponent();
            this.totalPrice = totalPrice;

            this.Load += new EventHandler(Payment_method_screen_Load);
        }

        private void Payment_method_screen_Load(object sender, EventArgs e)
        {
            this.priceValueLabel.Text = totalPrice.ToString()+"zł";
        }

        private void discountButton_Click(object sender, EventArgs e)
        {
            string enteredCode = discountCodeTextbox.Text;
            string query = $"SELECT * FROM Promotions WHERE PromoCode = '{enteredCode}'";

            List<Promotion> promotions_matching_code = dbm.ExecuteQuery(query, Promotion.MaptoDiscount);
            if (promotions_matching_code.Count > 1) throw new Exception("More than one promotion with the same code");
            if (promotions_matching_code.Count == 1)
            {
                decimal newPrice = promotions_matching_code[0].calculateDiscount(totalPrice);
                totalPrice= newPrice;

                this.priceValueLabel.Text = totalPrice.ToString() + "zł";
            }


        }
    }
}
