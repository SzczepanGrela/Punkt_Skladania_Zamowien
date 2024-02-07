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

namespace WindowsFormsApp1
{
    public partial class Login_window : BasePopup_window
    {
        string FilePath;

        public Login_window(string FilePath)
        {
            InitializeComponent();
            this.FilePath = FilePath;
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

            TxtFileOperations users_txt = new TxtFileOperations(FilePath);   // for simplicity, the name of the object is the name of the file, with '_' instead of '.'
            
            if (users_txt.Login(EnteredUsername, 0, EnteredPassword)) // 0 is the column index of the usernames in the file
            {
                

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
    }
}
