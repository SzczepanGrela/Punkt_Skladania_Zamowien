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
using WindowsFormsApp1.controls.forms;
using WindowsFormsApp1.controls.usercontrols;

namespace WindowsFormsApp1.usercontrols
{
    public partial class Menu_screen : BaseUserControl
    {
        public Menu_screen(Control parentContainer, char mode) : base(parentContainer, mode)
        {
            InitializeComponent();

            this.BackColor = parentContainer.BackColor;
           
        }

        private void ShopButton_Click(object sender, EventArgs e)
        {
            OpenControl(parentContainer, new Categories_screen(parentContainer, 's'), this);
            
        }

       
        private void PresentationButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}