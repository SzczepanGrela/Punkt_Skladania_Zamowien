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

        private bool Testable { get; set;}
       
        public Category_button()
        {
            InitializeComponent();
            Category_button_Load(this, null, "Category");  // default Category in case of mistake of creating empty object   



        }

        public Category_button(string name, byte[] image, int ID, bool Testable)
        {


            InitializeComponent();



            Category_button_Load(this, null, name, image);

            this.Testable = Testable;
            
            this.categoryID = ID;

            
            
          

        }


        private void Category_button_Load(object sender, EventArgs e, string name, byte[] image = null)
        {
            if (image != null)
            {
                this.pictureBox.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(image));
            }


            Label CategoryName = new Label
            {
                Parent = pictureBox,
                BackColor = Color.Transparent,
                Dock = DockStyle.Fill,
                Font = new Font("Impact", 20F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(238))),
                ForeColor = Color.White,
                Location = new Point(0, 0),
                Name = "CategoryName",
                Size = new Size(150, 150),
                TabIndex = 1,
                Text = name, 
                TextAlign = ContentAlignment.MiddleCenter,
                
            };
            CategoryName.Click += new EventHandler(CategoryButton_Click);
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {


            MainPanel_screen.Open(new Products_screen(categoryID, Testable));
        }


        public static List<UserControl> CreateCategoryButtons(List<Category> categories, bool Testable)
        {
            List<UserControl> categoryButtons = new List<UserControl>();
            foreach (Category category in categories)
            {
                Category_button categoryButton = new Category_button(category.Name, category.Image, category.ID, Testable);
               
                categoryButtons.Add(categoryButton);

            }

            return categoryButtons;
        }
    }
}
