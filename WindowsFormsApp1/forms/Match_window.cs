using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Match_window : Form
    {
        public Match_window()
        {
            InitializeComponent();
<<<<<<< Updated upstream:WindowsFormsApp1/forms/Match_window.cs
=======
            openForm(this, new MenuForm(this),null);
            this.parentForm = parentForm;
>>>>>>> Stashed changes:WindowsFormsApp1/forms/Panel_form.cs
        }
    }
}
