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
        public MainPanel_screen()
        {
            InitializeComponent();

            this.Load += new EventHandler(MainPanel_screen_Load);
        }

        private void MainPanel_screen_Load(object sender, EventArgs e)
        {
            

            OpenControl(new Menu_screen(), this);
        }
    }
}
