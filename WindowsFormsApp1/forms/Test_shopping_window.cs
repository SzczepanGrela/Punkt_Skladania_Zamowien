using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Forms
{
    public partial class Test_shopping_window : BaseForm
    {
        Control parentContainer;
        public Test_shopping_window(Control parentContainer)
        {
            InitializeComponent();
            //Methods.LoadImagesAndCreateButtons(this.panel , @"..\..\data\images\icons\categories");
            this.parentContainer = parentContainer;
        }


        
    



}
}
