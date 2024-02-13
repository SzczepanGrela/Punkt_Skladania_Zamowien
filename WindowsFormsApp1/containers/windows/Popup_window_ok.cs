using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes;


namespace WindowsFormsApp1.controls.forms
{
    public partial class Popup_window_ok : BasePopup_window
    {
        public Popup_window_ok(string message) : base()
        {
           
            InitializeComponent();
           
            this.MessageLabel.Text = message;

            this.Load += new EventHandler(Popup_window_ok_Load);
            
           
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Popup_window_ok_Load(object sender, EventArgs e)
        {
            this.OkButton.Focus();
        }
    }
}
