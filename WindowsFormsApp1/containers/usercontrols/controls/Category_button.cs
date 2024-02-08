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
using WindowsFormsApp1.classes.DataObjects;
using WindowsFormsApp1.containers.usercontrols.controls;
using WindowsFormsApp1.controls.usercontrols;

namespace WindowsFormsApp1.containers.usercontrols.controls
{
    public partial class Category_button : BaseUserControl
    {
        int categoryID = 0;
        BaseUserControl currentTab = null;
        public Category_button()
        {
            InitializeComponent();
            Category_button_Load(this, null, "Category");


        }

        public Category_button(string name, byte[] image, int ID, char mode, BaseUserControl categoryTab)
        {


            InitializeComponent();

            if (image != null)
            {
                this.pictureBox1.Image = Image.FromStream(new System.IO.MemoryStream(image));
            }


            Category_button_Load(this, null, name);


            this.currentTab = categoryTab;
            this.categoryID = ID;
            this.mode = mode;
            this.parentContainer = categoryTab.parentContainer;
            
            this.Click += new EventHandler(CategoryButton_Click);
        }


        private void Category_button_Load(object sender, EventArgs e, string name)
        {
            Label CategoryName = new Label();
            CategoryName.Parent = pictureBox1;
            CategoryName.BackColor = System.Drawing.Color.Transparent;
            CategoryName.Dock = System.Windows.Forms.DockStyle.Fill;
            CategoryName.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            CategoryName.ForeColor = Color.White;
            CategoryName.Location = new System.Drawing.Point(0, 0);
            CategoryName.Name = "CategoryName";
            CategoryName.Size = new System.Drawing.Size(150, 150);
            CategoryName.TabIndex = 1;
            CategoryName.Text = name;
            CategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            CategoryName.Click += new EventHandler(CategoryButton_Click);







        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {


            OpenControl(parentContainer, new Items_list_screen(parentContainer, mode, categoryID), currentTab );
        }
    }
}
