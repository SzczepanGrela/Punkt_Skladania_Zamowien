﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.forms;

namespace WindowsFormsApp1.classes
{
    public partial class BaseForm : Form
    {
       
        public BaseForm()
        {
            InitializeComponent();
            

        }

        protected void ResetMenu(Control parentContainer)
        {

            openForm(parentContainer, new Panel_form(parentContainer), null);
            Main_window.previousWindows.Clear(); // remove all elements from stack

            
            

        }

        protected void openForm(Control parentContainer, BaseForm newForm, BaseForm currentForm)   // open form in panel or other container (like form)
       
        {
            if(currentForm != null) Main_window.previousWindows.Push(currentForm);
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            parentContainer.Controls.Clear();
            parentContainer.Controls.Add(newForm);
            newForm.Show();
        }

        


    }



}
