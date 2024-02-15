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
    public partial class Popup_window_CustomerLogin : BasePopup_window
    {


        public Popup_window_CustomerLogin()
        {
            InitializeComponent();

            this.BackColor = base.BackColor;
        }

        private void login_window_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string EnteredUsername = usernameTextbox.Text;
            string EnteredPassword = passwordTextbox.Text;

            Customer loginPerson = new Customer(EnteredUsername, EnteredPassword);

            int customerID = loginPerson.Login();

            if(customerID != -10)
            {

                Popup_window_ok popup = new Popup_window_ok("Logged sucessfully");
                popup.OpenPopup();
                if(popup.DialogResult == DialogResult.OK)
                {
                    this.Close();
                    Main_window.GetInstance().Log_In(customerID);
                }

                
            }


            else
            {
                this.welcomeLabel.Text = "Wrong username or password\nTry again!";
                this.welcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
                this.welcomeLabel.ForeColor = Color.Red;
                this.passwordTextbox.Text = "";
                this.usernameTextbox.Text = "";

            }



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
