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
    public partial class Login_window : BaseForm
    {
        const string FilePath = @"../../Data/accounts/users/users.txt"; // Path to the users.txt file

        public Login_window()
        {
            InitializeComponent();
        }

        private void login_window_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string EnteredUsername = textBox1.Text;
            string EnteredPassword = textBox2.Text;

            TxtFileOperations users_txt = new TxtFileOperations(FilePath);   // for simplicity, the name of the object is the name of the file, with '_' instead of '.'
            
            if (users_txt.Login(EnteredUsername, 0, EnteredPassword)) // 0 is the column index of the usernames in the file
            {
                MessageBox.Show("Login succesful."); 

            }
            else
            {
                MessageBox.Show("Login failed. The username or password you entered is incorrect. Please try again.");

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

    }
}
