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


namespace WindowsFormsApp1
{
    public partial class Login_window : Form
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
            string EnteredLogin = textBox1.Text; // Entered login
            string EnteredPassword = textBox2.Text; // Entered password

            if (File.Exists(FilePath))
            {
                string[] lines = File.ReadAllLines(FilePath); // Reading all lines from the file
                
                foreach (string line in lines)
                {
                    string[] passcodes = line.Split(':'); // Splitting the line into login and password
                    string login = passcodes[0]; // Login
                    if (login != EnteredLogin) continue; // If the login is not correct, continue

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
            else MessageBox.Show("File not found");
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
