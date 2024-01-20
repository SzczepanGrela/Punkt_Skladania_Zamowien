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
        BaseForm parentForm;
        public Panel_form(BaseForm parentForm)
        {
            InitializeComponent();
            openForm(this, new MenuForm(this),null);
            this.parentForm = parentForm;
        }
    }
}
