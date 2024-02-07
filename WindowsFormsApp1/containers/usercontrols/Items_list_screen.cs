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
using WindowsFormsApp1.classes.FileOperations;

namespace WindowsFormsApp1.controls.usercontrols
{
    public partial class Items_list_screen : BaseUserControl
    {
        TxtFileOperations items_txt = new TxtFileOperations(@"..\..\data\items\shopping\items.txt");

        public Items_list_screen(Control parentContainer, char mode): base(parentContainer, mode) 
        {
            InitializeComponent();

            this.Load += new EventHandler(Items_list_screen_Load);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Items_list_screen_Load(object sender, EventArgs e)
        {
            string[] file = items_txt.ReadFile();
            string[][] items = Methods.splitArray(file, ';');
            
            
        }
    }
}
