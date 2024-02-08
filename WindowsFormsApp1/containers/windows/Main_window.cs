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
using WindowsFormsApp1.controls.forms;
using WindowsFormsApp1.usercontrols;



namespace WindowsFormsApp1
{
    public partial class Main_window : BaseForm
    {

        
        public Main_window()
        {
            InitializeComponent();


            this.SetForm(true, null);
            //pf = new Panel_form(MainPanel);

            UserControl mc = new Menu_screen(MainPanel, ' ');

            OpenControl(MainPanel, mc, null);

            

            
            

        }

       
         public static ControlStack previousControls = new ControlStack(); // Stack storing previous controls

        



        private void ReturnButton_Click(object sender, EventArgs e)
        {

            if (previousControls.Count() > 0)
            {

                Control prevScreen = previousControls.Pop();
                OpenControl(MainPanel,prevScreen,null); // open prev form, without adding current one to stack
            }

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {

            DialogResult loginStatus = OpenPopup(this.MainPanel, new Login_window(@"../../Data/accounts/users/users.txt"));
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            

            DialogResult dr = OpenPopup(this.MainPanel, new Popup_window_yn("Are you sure you want to reset tabs?"));

            if (dr == DialogResult.Yes)
            {
                ResetMenu(MainPanel);
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
    }
}
