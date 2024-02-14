using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes;
using WindowsFormsApp1.classes.DataObjects;
using WindowsFormsApp1.classes.FileOperations;
using WindowsFormsApp1.controls.forms;

namespace WindowsFormsApp1.controls.usercontrols
{
    public partial class Payment_method_screen : BaseUserControl
    {
        private decimal totalPrice { get; set;}

        private decimal GiftCardDebit { get; set; }
        

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
                

                this.priceValueLabel.Text = newPrice.ToString() + "zł";
            }


        }

        private void checkCodeButton_Click(object sender, EventArgs e)
        {
            DatabaseManager dbm = DatabaseManager.GetInstance();
            string enteredCode = giftcardTextbox.Text;
            string query = $"SELECT * FROM GiftCards WHERE GiftCardCode = '{enteredCode}' ;";

            List<GiftCard> giftCards_matching_code = dbm.ExecuteQuery(query, GiftCard.MapToGiftCard);

            if (giftCards_matching_code.Count > 1) throw new Exception("More than one gift card with the same code");

            else if (giftCards_matching_code.Count == 1)
            {
                this.GiftCardDebit = giftCards_matching_code[0].Debit;

                string message = $"Your card's balance is: {GiftCardDebit}zł\n";
                if (GiftCardDebit < totalPrice)
                {
                    message += "You don't have enough money on your card to pay for this order";

                    OpenPopup(new Popup_window_ok(message));
                }
                else
                {
                    string newBalance = (GiftCardDebit - totalPrice).ToString(CultureInfo.InvariantCulture);  // change of polish ','  to universal (and supppported by sql '.') 
                    message += $"Your new balance will be: {newBalance}zł\nDo you want to proceed?";

                    Popup_window_yn window = new Popup_window_yn(message);
                    OpenPopup(window);
                    if (window.DialogResult == DialogResult.Yes)
                    {

                        

                        query = $"UPDATE GiftCards SET Value = {newBalance} WHERE GiftCardCode = '{enteredCode}'";
                        
                        dbm.ExecuteCommand(query);

                        OpenPopup(new Popup_window_ok("Your card has been charged"));
                    }
                }


            }
            else OpenPopup(new Popup_window_ok("GiftCard not found in database"));
            
           


        }

        private void UseGiftCard(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
