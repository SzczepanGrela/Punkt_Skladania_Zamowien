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

   
        private void button1_Click(object sender, EventArgs e)
        {
            string EnteredUsername = usernameTextbox.Text;
            string EnteredPassword = passwordTextbox.Text;

            Customer loginPerson = new Customer(EnteredUsername, EnteredPassword);

            loginPerson = loginPerson.Login();

            if(loginPerson != null)
            {
                Main_window main_Window = Main_window.GetInstance();

                this.Close();
                main_Window.Log_In(loginPerson);
                Popup_window_ok popup = new Popup_window_ok("Logged sucessfully");
                popup.OpenPopup();
                

                
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
   
        private void leaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            new Popup_window_AdminLogin().OpenPopup();

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new Popup_window_Register().OpenPopup();
        }
    }
}
