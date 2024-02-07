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



namespace WindowsFormsApp1.classes
{
    public partial class BaseUserControl : UserControl, IContainerControlOperations
    {
        public Control parentContainer = null;

        protected char mode = ' ';


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



        public void AddButtonstoFlowPanel(string[] buttonnames, FlowLayoutPanel panel, int columns)
        {

            BaseUserControl parent = (BaseUserControl)panel.Parent;   // TO DO: CHANGE THE WAY OF GETTING THE WIDTH OF THE PANEL
            int panelWidth = parent.Parent.Size.Width;
            int scrollbarWidth = SystemInformation.VerticalScrollBarWidth;
            int buttonWidth = (int)((panelWidth-scrollbarWidth) / (columns*1.1));  
            int gapWidth = (panelWidth - columns * buttonWidth - scrollbarWidth) / (2*columns);
            for (int i=0;i<buttonnames.Length;i++)
            {
                

                Button categoryButton = new Button();
                categoryButton.Text = buttonnames[i];
                categoryButton.BackColor = Color.White;
                
                categoryButton.Margin = new Padding(gapWidth, gapWidth, gapWidth, gapWidth);
                



                categoryButton.Size = new Size(buttonWidth, buttonWidth);
               

                categoryButton.Click += new EventHandler(OnCategoryButtonClick);
                
                panel.Controls.Add(categoryButton);
            }

        }

        public void AddControlstoFlowPanel(Control[] controls, FlowLayoutPanel panel, int columns)
        {

            BaseUserControl parent = (BaseUserControl)panel.Parent;   // TO DO: CHANGE THE WAY OF GETTING THE WIDTH OF THE PANEL
            int panelWidth = parent.Parent.Size.Width;
            int scrollbarWidth = SystemInformation.VerticalScrollBarWidth;
            int controlWidth = (int)((panelWidth - scrollbarWidth) / (columns * 1.1));
            int gapWidth = (panelWidth - columns * controlWidth - scrollbarWidth) / (2 * columns);
            for (int i = 0; i < controls.Length; i++)
            {
                controls[i].Margin = new Padding(gapWidth, gapWidth, gapWidth, gapWidth);
                controls[i].Size = new Size(controlWidth, controlWidth);
                panel.Controls.Add(controls[i]);
            }

        }


        

        private void OnCategoryButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string category = button.Text;
            MessageBox.Show(category);
        }




    }
}
