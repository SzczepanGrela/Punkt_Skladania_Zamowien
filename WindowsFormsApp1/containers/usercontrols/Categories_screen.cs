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
    public partial class Categories_screen : BaseUserControl
    {


        TxtFileOperations categories_txt = new TxtFileOperations(@"..\..\data\items\shopping\categories.txt");
        public Categories_screen(Control parentContainer, char mode) : base(parentContainer, mode)
        {
            InitializeComponent();




            this.Load += new EventHandler(Categories_screen_Load);  //loading buttons from file



        }

        private void Categories_screen_Load(object sender, EventArgs e)
        {

            string[] categories = categories_txt.ReadFile();

            //string[] categories = categories_txt.FindMatchingRecords("true", 1);

            categories = Methods.splitArray(categories, ';', 0);
            AddButtonstoFlowPanel(categories, categoriesPanel, 3);



        }

        private void categoriesTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tablePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lookinforLabel_Click(object sender, EventArgs e)
        {

        }


    }
}
