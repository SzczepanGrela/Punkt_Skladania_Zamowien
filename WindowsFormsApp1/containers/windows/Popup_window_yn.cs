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

namespace WindowsFormsApp1.controls.forms
{
    public partial class Popup_window_yn : BasePopup_window
    {

        public Popup_window_yn(string message)
        {
            InitializeComponent();
            this.MessageLabel.Text = message;
            this.Load += Popup_window_yn_Load;
            
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void Popup_window_yn_Load(object sender, EventArgs e)
        {
            
        }
    }
}
