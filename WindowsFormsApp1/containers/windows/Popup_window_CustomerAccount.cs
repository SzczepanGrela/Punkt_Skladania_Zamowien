using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApp1.classes;
using WindowsFormsApp1.classes.FileOperations;
using WindowsFormsApp1.classes.DataObjects;
using WindowsFormsApp1.containers.windows;
using WindowsFormsApp1.controls.forms;

namespace WindowsFormsApp1
{
    public partial class Popup_window_CustomerAccount : BasePopup_window
    {


        public Popup_window_CustomerAccount()
        {
            InitializeComponent();

            this.Load += Popup_window_CustomerAccount_Load;

            this.BackColor = base.BackColor;
        }

        private void Popup_window_CustomerAccount_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = $"Hi {Main_window.GetLoggedCustomerName()},\nWelcome to the customer account window";
        }

        private void login_window_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Main_window main_Window = Main_window.GetInstance();

            main_Window.Log_Out();
            this.Close();
            Popup_window_ok popup = new Popup_window_ok("Logged out successfully");
            popup.OpenPopup();



        }







        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            new Popup_window_AdminLogin().OpenPopup();

        }
    }
}
