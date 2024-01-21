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

namespace WindowsFormsApp1.forms
{
    public partial class Panel_form : BaseForm
    {

        public Panel_form(Control parentContainer)
        {
            InitializeComponent();
            this.setResolution(false);
            this.parentContainer = parentContainer;
            

            //openForm(this, new MenuForm(this),null); 

        }
    }
}
