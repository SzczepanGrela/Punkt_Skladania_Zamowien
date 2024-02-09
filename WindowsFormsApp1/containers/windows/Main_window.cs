using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes;
using WindowsFormsApp1.containers.usercontrols;
using WindowsFormsApp1.controls.forms;
using WindowsFormsApp1.usercontrols;



namespace WindowsFormsApp1
{
    public partial class Main_window : BaseForm
    {

        
        public Main_window()
        {
            InitializeComponent();


            this.Load += new EventHandler(Main_window_Load);
            //pf = new Panel_form(MainPanel);

          //ResetMenu(this.MainPanel);

        }

       
         public static ControlStack previousControls = new ControlStack(); // Stack storing previous controls

        



        private void ReturnButton_Click(object sender, EventArgs e)
        {

            if (previousControls.Count() > 1)
            {

                Control currentScreen = previousControls.Pop();
                currentScreen.Controls.Clear();
                currentScreen.Dispose();
               
                
                Control prevScreen = previousControls.Peek();
                prevScreen.Show();
            }
            GC.Collect();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {

            //DialogResult loginStatus = OpenPopup(this.MainPanel, new Login_window(@"../../Data/accounts/users/users.txt"));
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            

            DialogResult dr = OpenPopup(this.MainPanel, new Popup_window_yn("Are you sure you want to reset all tabs?"));

            if (dr == DialogResult.Yes)
            {
               ResetMenu(this.MainPanel);
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
            
            

        }
    }
}
