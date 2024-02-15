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
using WindowsFormsApp1.containers.usercontrols;
using WindowsFormsApp1.controls.forms;

namespace WindowsFormsApp1.controls.usercontrols
{
    public partial class Payment_method_screen : BaseUserControl
    {
        private decimal totalPrice { get; set; }

        private decimal discountPrice { get; set; }

        private decimal GiftCardDebit { get; set; }


        DatabaseManager dbm = DatabaseManager.GetInstance();
        public Payment_method_screen(decimal totalPrice)
        {
            InitializeComponent();
            this.totalPrice = this.discountPrice = totalPrice;

            this.Load += new EventHandler(Payment_method_screen_Load);
        }

        private void Payment_method_screen_Load(object sender, EventArgs e)
        {
            this.priceValueLabel.Text = totalPrice.ToString() + "zł";
        }

        private void discountButton_Click(object sender, EventArgs e)
        {
            string enteredCode = discountCodeTextbox.Text;
            string query = $"SELECT * FROM Promotions WHERE PromoCode = '{enteredCode}'";

            List<Promotion> promotions_matching_code = dbm.ExecuteQuery(query, Promotion.MaptoDiscount);
            if (promotions_matching_code.Count > 1) throw new Exception("More than one promotion with the same code");
            if (promotions_matching_code.Count == 1)
            {
                discountPrice = promotions_matching_code[0].calculateDiscount(totalPrice);


                this.priceValueLabel.Text = discountPrice.ToString() + "zł";
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
                if (GiftCardDebit < discountPrice)
                {
                    message += "You don't have enough money on your card to pay for this order";

                    OpenPopup(new Popup_window_ok(message));
                }
                else
                {
                    string newBalance = (GiftCardDebit - discountPrice).ToString(CultureInfo.InvariantCulture);  // change of polish ','  to universal (and supppported by sql '.') 
                    message += $"Your new balance will be: {newBalance}zł\nDo you want to proceed?";

                    Popup_window_yn window = new Popup_window_yn(message);
                    OpenPopup(window);
                    if (window.DialogResult == DialogResult.Yes)
                    {

                        registerTransaction();

                        Popup_window_ok popup = new Popup_window_ok("Your card has been charged");
                        OpenPopup(popup);
                        if (popup.DialogResult == DialogResult.OK)
                        {
                            localCart.ClearCarts();  // Clear both carts
                            
                            MainPanel_screen.Open(new Finalised_purchase_screen());
                        }
                    }
                }


            }
            else OpenPopup(new Popup_window_ok("GiftCard not found in database"));




        }


        private void registerTransaction()
        {
            DatabaseManager dbm = DatabaseManager.GetInstance();


            string[] columns = new string[] { "Value" };
            string[][] values = new string[1][] { new string[1] { $"{columns[0]} - {discountPrice}".Replace(',', '.') } };

            dbm.ExecuteCommand(true, "GiftCards", columns, values, $"GiftCardCode = '{giftcardTextbox.Text}'");



            columns = new string[3] {"CustomerID", "CreatedDate","Status"};
            values = new string[1][] { new string[3]{$"199", $"GETDATE()", $"'Completed'" } };  //199 is the ID of OrderHub, when user is not logged in


            int CartID = dbm.ExecuteCommandGetID("Carts","CartID",columns,values)[0];

            columns = new string[3] { "CartID", "PriceAtPurchase", "TransactionDate" };
            values = new string[1][] { new string[3] { $"{CartID}", $"{discountPrice}".Replace(',', '.'), $"GETDATE()" } };   

            
            dbm.ExecuteCommand(false,"Transactions",columns,values,"");   //false means it's not an update.
            
        }

    }
}
