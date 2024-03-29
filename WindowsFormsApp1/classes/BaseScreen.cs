﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.controls.forms;
using WindowsFormsApp1.interfaces;
using WindowsFormsApp1.usercontrols;
using WindowsFormsApp1.classes;
using System.Data.SqlClient;
using WindowsFormsApp1.classes.DataObjects;
using WindowsFormsApp1.containers.usercontrols.controls;
using WindowsFormsApp1.containers.usercontrols;
using WindowsFormsApp1.controls.usercontrols;



namespace WindowsFormsApp1.classes
{
    public partial class BaseScreen : UserControl
    {


        protected string query;
        

        public BaseScreen()
        {
            InitializeComponent();
        }



        public DialogResult OpenPopup(BasePopup_window newPopup)
        {

            newPopup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            newPopup.FormBorderStyle = FormBorderStyle.None;
            newPopup.ControlBox = false;
            newPopup.StartPosition = FormStartPosition.CenterParent;



            newPopup.ShowDialog();

            return newPopup.DialogResult;

        }



        public void AddButtonstoFlowPanel(UserControl[] controls, FlowLayoutPanel panel, int columns)
        {
            // works only for table of same type of controls

            var examplecontrol = controls[0];




            int scrollbarWidth = SystemInformation.VerticalScrollBarWidth;
            int panelWidth = panel.Size.Width - scrollbarWidth;

            int controlWidth = (int)((panelWidth - scrollbarWidth) / (columns * 1.12));
            float proportion = ((float)controlWidth / examplecontrol.Width);
            int controlHeight = (int)(examplecontrol.Height * proportion);
            int spaceleft = panelWidth - columns * controlWidth;
            int gapWidth = spaceleft / (2 * columns);
            int gapHeight = gapWidth;
            for (int i = 0; i < controls.Length; i++)
            {
                controls[i].Margin = new Padding(gapWidth, gapHeight, gapWidth, gapHeight);
                controls[i].Padding = new Padding(0, 0, 0, 0);
                controls[i].Size = new Size(controlWidth, controlHeight);

            
                panel.Controls.Add(controls[i]);

            }

      

        }



        public void AddSlicestoPanel(UserControl[] controls, Panel panel)
        {
           
            if (controls.Length == 0) return;
            var examplecontrol = controls[0];
            int panelWidth = panel.Size.Width; 

            int scrollbarWidth = SystemInformation.VerticalScrollBarWidth;
            

            if (controls.Length * (examplecontrol.Size.Height*1.05) >= panel.Size.Height)
            {
                 panelWidth -= scrollbarWidth;
            }
            float proportion = ((float)panelWidth / examplecontrol.Width); // all controls are 600px wide by default

            int controlWidth = panelWidth;
             
            int controlHeight = (int)(examplecontrol.Height * proportion);
            
            int gapHeight = (int)(0.05 * controlHeight);
            for (int i = 0; i < controls.Length; i++)
            {
                controls[i].Margin = new Padding(0, gapHeight, 0, gapHeight);
                controls[i].Padding = new Padding(0, 0, 0, 0);
                controls[i].Size = new Size(controlWidth, controlHeight);
                controls[i].Dock = DockStyle.Top;

                panel.Controls.Add(controls[i]);

            }

          
        }




    }
}
