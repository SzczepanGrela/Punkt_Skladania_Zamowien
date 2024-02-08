using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.containers.usercontrols.controls
{
    public partial class testControl : UserControl
    {
        public testControl()
        {
            InitializeComponent();

            this.Click += new EventHandler(testControl_Click);
        }

        private void testControl_Load(object sender, EventArgs e)
        {

        }

        private void testControl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test control clicked");
        }
    }
}
