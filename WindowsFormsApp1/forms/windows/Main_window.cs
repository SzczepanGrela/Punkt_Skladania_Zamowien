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
using WindowsFormsApp1.Classes;

using WindowsFormsApp1.Forms;
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

            UserControl mc = new Menu_control(MainPanel);

            openControl(MainPanel, mc, null);

            

            //ResetMenu(pf);
            

        }

       
         public static ControlStack previousControls = new ControlStack(); // Stack storing previous controls

        private Login_window lw; // Var storing if login window was already opened




        private void ReturnButton_Click(object sender, EventArgs e)
        {

            if (previousControls.Count() > 0)
            {

                Control prevScreen = previousControls.Pop();
                openControl(MainPanel,prevScreen,null); // open prev form, without adding current one to stack
            }

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {

            if (lw == null || lw.IsDisposed)
            {
                lw = new Login_window();
                lw.Show();
            }
            else
            {
                // If the window is already opened, bring it to front
                lw.BringToFront();
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            ResetMenu(MainPanel);
        }

        private void TopBarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
