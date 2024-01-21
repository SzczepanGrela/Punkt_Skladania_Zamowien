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

namespace WindowsFormsApp1.Forms
{
    public partial class Matching_form : BaseForm
    {
        
        public Matching_form(Control parentContainer)
        {
            InitializeComponent();
            this.SetForm(false, parentContainer);
            
        }

    }
}
