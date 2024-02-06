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

namespace WindowsFormsApp1.usercontrols
{
    public partial class Menu_screen : BaseUserControl
    {
        public Menu_screen(Control parentContainer, char mode) : base(parentContainer, mode)
        {
            InitializeComponent();
           
        }

        private void ShopButton_Click(object sender, EventArgs e)
        {
            OpenPopup(this.parentContainer, new Popup_window_ok("Przykładowe zdanie posiadające trochę więcej tekstu by sprawdzić jak się zachowa label"));
            
        }

       
        private void PresentationButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
