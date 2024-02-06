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

namespace WindowsFormsApp1.controls.usercontrols
{
    public partial class Items_list_screen : BaseUserControl
    {
        public Items_list_screen(Control parentContainer, char mode): base(parentContainer, mode) 
        {
            InitializeComponent();
        }
    }
}
