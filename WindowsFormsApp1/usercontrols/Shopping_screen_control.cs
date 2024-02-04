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

namespace WindowsFormsApp1.usercontrols
{
    public partial class Shopping_screen_control : BaseUserControl
    {
        public Shopping_screen_control(Control parentContainer)
        {
            InitializeComponent();
            this.parentContainer = parentContainer;
        }
    }
}
