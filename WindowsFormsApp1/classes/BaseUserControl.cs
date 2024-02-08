using System;
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



namespace WindowsFormsApp1.classes
{
    public partial class BaseUserControl : UserControl, IContainerControlOperations
    {
        public Control parentContainer = null;

        protected char mode = ' ';
        protected string query;
        BaseUserControl currentScreen = null;

        public BaseUserControl()
        {
            InitializeComponent();
        }
        public BaseUserControl(Control parentContainer, char mode)
        {
            InitializeComponent();
            this.parentContainer = parentContainer;
         
            this.mode = mode;
        }

        public void ResetMenu(Control parentContainer)
        {


            OpenControl(parentContainer, new usercontrols.Menu_screen(parentContainer, ' '), null);
            Main_window.previousControls.Clear(); // remove all elements from stack

        }



        public void OpenControl(Control parentContainer, Control newControl, Control currentControl)  // open "new" in "parent"; "current" add to  stack
        {
            if (currentControl != null) Main_window.previousControls.Push(currentControl);

            newControl.Dock = DockStyle.Fill;

            parentContainer.Controls.Clear();

            
            parentContainer.Controls.Add(newControl);

            
            

            newControl.BackColor = parentContainer.BackColor;
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



        public void AddControlstoFlowPanel(List<Control> controls, FlowLayoutPanel panel, int columns)
        {

            BaseUserControl parent = (BaseUserControl)panel.Parent;   // TO DO: CHANGE THE WAY OF GETTING THE WIDTH OF THE PANEL
            int panelWidth = parent.Parent.Size.Width;
            int scrollbarWidth = SystemInformation.VerticalScrollBarWidth;
            int buttonWidth = (int)((panelWidth - scrollbarWidth) / (columns * 1.1));
            int gapWidth = (panelWidth - columns * buttonWidth - scrollbarWidth) / (2 * columns);


            foreach (Control control in controls)
            {

                control.Margin = new Padding(gapWidth, gapWidth, gapWidth, gapWidth);

                control.Size = new Size(buttonWidth, buttonWidth);

                panel.Controls.Add(control);

                
            }

        }

       

        




        public void AddControlstoFlowPanel(BaseUserControl[] controls, FlowLayoutPanel panel, int columns)
        {
            // works only for table of same type of controls
           
            var examplecontrol = controls[0];

           
            

            int scrollbarWidth = SystemInformation.VerticalScrollBarWidth;
            int panelWidth = panel.Size.Width - scrollbarWidth;

            int controlWidth = (int)((panelWidth - scrollbarWidth) / (columns * 1.12));
            float proportion = ((float)controlWidth / examplecontrol.Width);
            int controlHeight = (int)( examplecontrol.Height  *  proportion);
            int spaceleft = panelWidth - columns * controlWidth;
            int gapWidth = spaceleft/ (2 * columns);
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

        protected void AssignClickEventToAllControls(Control parent, BaseUserControl nextScreen)
        {
            foreach (Control control in parent.Controls)
            {
                control.Click += (sender, e) => ClickEventForButtons(sender, e, nextScreen);


                // Jeśli kontrolka zawiera inne kontrolki, zastosuj rekurencję
                if (control.HasChildren)
                {
                    AssignClickEventToAllControls(control,nextScreen);
                }
            }
        }


        private void ClickEventForButtons(object sender, EventArgs e,BaseUserControl nextScreen)
        {
            MessageBox.Show("Button clicked");

            //OpenControl(parentContainer, nextScreen, this);
        }
        







    }
}
