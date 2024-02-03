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
        string FilePath = @"../../Data/accounts/users/users.txt"; // Path to the users.txt file

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
            string[] lines = users_txt.ReadFile();
            foreach (string line in lines)
            {
                string[] passcodes = line.Split(':'); // Splitting the line into login and password
                string login = passcodes[0]; // Login
                if (login != EnteredUsername) continue; // If the login is not correct, continue

                else
                {

                    string password = passcodes[1]; // Password
                    if (password == EnteredPassword) // If the password is correct
                    {

                        MessageBox.Show("Login successful"); // Show the message
                                                             //close this window
                        this.Close();

                    }
                    else // If the password is incorrect
                    {

                        break; // Stop searching
                    }



                }
            }
            MessageBox.Show("Login failed. The username or password you entered is incorrect. Please try again."); // Show the message

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
