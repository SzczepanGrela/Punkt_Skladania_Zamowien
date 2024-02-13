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
using WindowsFormsApp1.containers.usercontrols.controls;
using WindowsFormsApp1.controls.usercontrols.controls;
using WindowsFormsApp1.usercontrols;

namespace WindowsFormsApp1.containers.usercontrols
{
    public partial class MainPanel_screen : BaseUserControl
    {
        private static MainPanel_screen instance;
        

        public MainPanel_screen()
        {
            InitializeComponent();

            this.Load += new EventHandler(MainPanel_screen_Load);
        }

        private void MainPanel_screen_Load(object sender, EventArgs e)
        {
            instance = this;
            Open(new Menu_screen());
        }

        public static void Open(Control screen)
        {
            previousScreens.Push(screen);
            screen.Dock = DockStyle.Fill;
            int length = instance.Controls.Count;
            if(length> 0)instance.Controls[length -1].Hide();  // Hide the previous screen

            instance.Controls.Add(screen);


            screen.BackColor = screen.Parent.BackColor;
            screen.Show();

        }


        public static MainPanel_screen getMainPanel()
        {
            
            if (instance == null)
            {
                instance = new MainPanel_screen();
            }
            return instance;
        }
        
    }
}
