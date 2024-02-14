using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.containers.usercontrols;
using WindowsFormsApp1.containers.usercontrols.controls;

namespace WindowsFormsApp1.classes
{
    public partial class BasePopup_window : Form
    {
        public BasePopup_window()
        {

            
            InitializeComponent();
            
        }


        public DialogResult OpenPopup()
        {

            this.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterParent;

            this.ShowDialog();

            return this.DialogResult;

        }


    }
}
