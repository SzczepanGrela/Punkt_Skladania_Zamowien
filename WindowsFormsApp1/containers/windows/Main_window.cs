using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes;
using WindowsFormsApp1.classes.DataObjects;
using WindowsFormsApp1.classes.FileOperations;
using WindowsFormsApp1.containers.usercontrols;
using WindowsFormsApp1.containers.usercontrols.controls;
using WindowsFormsApp1.controls.forms;
using WindowsFormsApp1.controls.usercontrols;
using WindowsFormsApp1.usercontrols;



namespace WindowsFormsApp1
{
    public partial class Main_window : BaseForm
    {
        
        private static Main_window instance;

        private bool default_user = true;

        private static Customer loggedCustomer;
        public Main_window()
        {
            InitializeComponent();


            this.Load += new EventHandler(Main_window_Load);
            

        }

       
        private static void ReturnButton_Click(object sender, EventArgs e)
        {

            if (previousScreens.Count() > 1)
            {

                Control currentScreen = previousScreens.Pop();
                currentScreen.Controls.Clear();
                currentScreen.Dispose();
               
                
                Control prevScreen = previousScreens.Peek();
                prevScreen.Show();
            }
            GC.Collect();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {

            DialogResult loginStatus = Main_window.OpenPopup(new Popup_window_CustomerLogin());

            
           
        }

        private static void HomeButton_Click(object sender, EventArgs e)
        {
            

            DialogResult dr = Main_window.OpenPopup(new Popup_window_yn("Are you sure you want to reset all tabs?\n (Your cart will be saved)"));

            if (dr == DialogResult.Yes)
            {
               ResetMenu();
            }
            else
            {
                // instructions for no
            }
        }

        private void TopBarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Main_window_Load(object sender, EventArgs e)
        {
            Log_Out();
            

        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            if (previousScreens.Peek() is Shopping_cart_screen) return;
            
            MainPanel_screen.Open(new Shopping_cart_screen());
        }




        public static Main_window GetInstance()
        {
            if (instance == null)
            {
                instance = new Main_window();
            }
            return instance;
        }


        public static DialogResult OpenPopup(BasePopup_window newPopup)
        {

            Size Main_windowSize = GetInstance().Size;
            //newPopup.Size = new Size((int)(Main_windowSize.Width *0.9),(int)(Main_windowSize.Height *0.35));  

            // size of popup doesnt change, fix later 

            

            newPopup.FormBorderStyle = FormBorderStyle.None;
            newPopup.ControlBox = false;
            newPopup.StartPosition = FormStartPosition.CenterParent;

            

            newPopup.ShowDialog();

            return newPopup.DialogResult;

        }

        private void Log_Out()
        {
            Log_In(199);

            default_user = true;

            CartItem.UpdateItemsinDB();
            localCart.ClearCarts();
            // logging out makes you log in into default account
        }

        internal void Log_In(int customerID)
        {
             default_user = false;
             loggedCustomer = new Customer(customerID);
              
            localCart.Login(customerID);

            
        }

        internal static int GetLoggedCustomerID()
        {
            return loggedCustomer.ID;
        }
    }
}
