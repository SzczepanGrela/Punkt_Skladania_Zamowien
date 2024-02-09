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
    public partial class BaseUserControl : UserControl
    {


        protected string query;
        BaseUserControl currentScreen = null;

        public BaseUserControl()
        {
            InitializeComponent();
        }



        public void OpenControl(Control newControl, Control parentControl)  // open "new" in "parent"
        {
            Main_window.previousControls.Push(newControl);
            newControl.Dock = DockStyle.Fill;
            parentControl.Controls.Clear();
            parentControl.Controls.Add(newControl);
            newControl.Show();
        }


        /* public void OpenControl(Control newControl, Control parentControl)
         {


             newControl.Dock = DockStyle.Fill;
             parentControl.Controls.Clear();
             parentControl.Controls.Add(newControl);
             newControl.Show();

         }*/

        public void OpenNewControl(Control newControl, Control currentControl)
        {
            Main_window.previousControls.Push(newControl);
            newControl.Dock = DockStyle.Fill;
            
            currentControl.Hide();

            currentControl.Parent.Controls.Add(newControl);
            

            newControl.BackColor = newControl.Parent.BackColor;
            newControl.Show();

        }





        public DialogResult OpenPopup(Control parentContainer, BasePopup_window newPopup)
        {

            newPopup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            newPopup.FormBorderStyle = FormBorderStyle.None;
            newPopup.ControlBox = false;
            newPopup.StartPosition = FormStartPosition.CenterParent;



            newPopup.ShowDialog();

            return newPopup.DialogResult;

        }




        /*public void AddButtonstoTable(string[] buttonNames, TableLayoutPanel table)
        {
            
            int columncount = table.ColumnCount;
            int rowcount = table.RowCount;
            int cellcount = columncount * rowcount;
            int numberofbuttons = buttonNames.Length;
            float cellheight = table.Height / (float)3;


            while (cellcount < numberofbuttons)
            {
                table.RowCount++;
                rowcount++;
                table.RowStyles.Add(new RowStyle(SizeType.Absolute, cellheight));
                cellcount += columncount;
            }

            

            
            for (int i = 0; i < numberofbuttons; i++)
            {
                Button categoryButton = new Button();
                categoryButton.Text = buttonNames[i];
                categoryButton.BackColor = Color.White;
                categoryButton.Dock = DockStyle.Fill;
                 
                table.Controls.Add(categoryButton) ;
                
            }
        }*/












        public void AddControlstoFlowPanel(BaseUserControl[] controls, FlowLayoutPanel panel, int columns)
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

            /*MessageBox.Show(this.Name+" " + this.Width);
            MessageBox.Show(this.parentContainer.Name + " " + this.parentContainer.Width );*/

        }


        public List<Control> AllcontrolstoList(Control control)
        {
            
            List<Control> controls = new List<Control>();
            foreach (Control c in control.Controls)
            {
                controls.Add(c);
                if (c.HasChildren)
                {
                    controls.AddRange(AllcontrolstoList(c));
                }
            }
            return controls;
        }

      





    }
}
