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
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1.containers.usercontrols.controls
{
    public partial class Category_button : UserControl
    {
        int categoryID = 0;
        BaseUserControl currentScreen = null;
        public Category_button()
        {
            InitializeComponent();
            Category_button_Load(this, null, "Category");  // default Category in case of mistake of creating empty object   



        }

        public Category_button(string name, byte[] image, int ID, BaseUserControl currentScreen)
        {


            InitializeComponent();



            Category_button_Load(this, null, name, image);


            this.currentScreen = currentScreen;
            this.categoryID = ID;
            
            this.Parent = currentScreen;

        }


        private void Category_button_Load(object sender, EventArgs e, string name, byte[] image = null)
        {
            if (image != null)
            {
                this.pictureBox.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(image));
            }


            Label CategoryName = new Label();
            CategoryName.Parent = pictureBox;
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

            //OpenControl(parentContainer, new Products_screen(parentContainer, mode, categoryID), currentScreen);

           

            currentScreen.OpenNewControl(new Products_screen(categoryID), currentScreen);
        }


        public static List<UserControl> CreateCategoryButtons(List<Category> categories, BaseUserControl Categories_screen)
        {
            List<UserControl> categoryButtons = new List<UserControl>();
            foreach (Category category in categories)
            {
                Category_button categoryButton = new Category_button(category.Name, category.Image, category.ID, Categories_screen);
               
                categoryButtons.Add(categoryButton);

            }

            return categoryButtons;
        }
    }
}
