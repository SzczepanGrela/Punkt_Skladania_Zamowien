﻿using System;
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
    public partial class Payment_method_screen : BaseScreen
    {
        private decimal TotalPrice { get; set; }

        private decimal DiscountPrice { get; set; }

        


        DatabaseManager dbm = DatabaseManager.GetInstance();
        public Payment_method_screen(decimal totalPrice)
        {
            InitializeComponent();
            this.TotalPrice = this.DiscountPrice = totalPrice;

            this.Load += new EventHandler(Payment_method_screen_Load);
        }

        private void Payment_method_screen_Load(object sender, EventArgs e)
        {
            this.priceValueLabel.Text = TotalPrice.ToString() + "zł";
        }

        private void discountButton_Click(object sender, EventArgs e)
        {
            string enteredCode = discountCodeTextbox.Text;
            string query = $"SELECT * FROM Promotions WHERE PromoCode = '{enteredCode}'";

            List<Promotion> promotions_matching_code = dbm.ExecuteQuery(query, Promotion.MaptoDiscount);
            if (promotions_matching_code.Count > 1) throw new Exception("More than one promotion with the same code");
            if (promotions_matching_code.Count == 1)
            {
                DiscountPrice = promotions_matching_code[0].calculateDiscount(TotalPrice);


                this.priceValueLabel.Text = DiscountPrice.ToString() + "zł";
            }


        }

        private void checkCodeButton_Click(object sender, EventArgs e)
        {
            bool PaymentAccepeted=false;

            string enteredCode = giftcardTextbox.Text;
            string query = $"SELECT * FROM GiftCards WHERE GiftCardCode = '{enteredCode}' ;";

            List<GiftCard> giftCards_matching_code = dbm.ExecuteQuery(query, GiftCard.MapToGiftCard);
            GiftCard giftCard = giftCards_matching_code[0];
            try
            {
                if (giftCards_matching_code.Count > 1) throw new Exception("More than one gift card with the same code");
                else if (giftCards_matching_code.Count == 0) OpenPopup(new Popup_window_ok("GiftCard not found in database"));
                else PaymentAccepeted = GiftCardPayment(giftCard);

            }catch (Exception ex)
            {
                OpenPopup(new Popup_window_ok(ex.Message));
                PaymentAccepeted = false;   ;
            }
            if (PaymentAccepeted)
            {
                RegisterTransaction();
                UpdateCartStatus();
                ChargeGiftCard(giftCard);
                localCart.GetShoppingCart().RemoveItemsFromStock();
                localCart.ClearCarts();  // Clear both carts

                Popup_window_ok popup = new Popup_window_ok("Your card has been charged");
                OpenPopup(popup);

                if (popup.DialogResult == DialogResult.OK)
                {


                    MainPanel_screen.Open(new Finalised_purchase_screen());
                }
            }
            else
            {
                Popup_window_ok popup = new Popup_window_ok("Transaction failed");
                OpenPopup(popup);
            }



        }


        private void RegisterTransaction()
        {

            Cart currentCart = localCart.GetShoppingCart();


            Transaction currentTransaction = new Transaction(localCart.GetShoppingCartID(), DiscountPrice, DateTime.Now, "GiftCard");

            dbm.InsertObjectGetID(currentTransaction, "Transactions", Transaction.MapTransactionToSqlParameters, "ID");



        }

        private void ChargeGiftCard(GiftCard giftCard)
        {
            DatabaseManager dbm = DatabaseManager.GetInstance();
            dbm.ExecuteCommand(true, "GiftCards", new string[] { "Value" }, new string[] { (giftCard.Debit - DiscountPrice).ToString(CultureInfo.InvariantCulture) }, $"GiftCardCode = '{giftcardTextbox.Text}'");
        }


        private void UpdateCartStatus()
        {
           

            dbm.ExecuteCommand(true, "Carts", new string[] { "Status" }, new string[] { "'Completed'" }, $"ID = {localCart.GetShoppingCartID()}");

        }


        private bool GiftCardPayment(GiftCard giftCard)
        {



            string message = $"Your card's balance is: {giftCard.Debit}zł\n";
            if (giftCard.Debit < DiscountPrice)
            {
                message += "You don't have enough money on your card to pay for this order";

                OpenPopup(new Popup_window_ok(message));

                return false;
            }
            else
            {
                string newBalance = (giftCard.Debit - DiscountPrice).ToString(CultureInfo.InvariantCulture);  // change of polish ','  to universal (and supppported by sql '.') 
                message += $"Your new balance will be: {newBalance}zł\nDo you want to proceed?";

                Popup_window_yn window = new Popup_window_yn(message);
                OpenPopup(window);


                return window.DialogResult == DialogResult.Yes;


               
            }


        }



    }
}




