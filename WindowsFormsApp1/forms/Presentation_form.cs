﻿using System;
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
    public partial class Presentation_form : BaseForm
    {
        Control parentContainer;
        public Presentation_form(Control parentContainer)
        {
            InitializeComponent();
            this.setResolution(false);
            this.parentContainer = parentContainer;
        }


    }
}
