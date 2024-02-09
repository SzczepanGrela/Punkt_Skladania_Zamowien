using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes;
using WindowsFormsApp1.classes.DataObjects;
using WindowsFormsApp1.classes.FileOperations;
using WindowsFormsApp1.containers.usercontrols.controls;

namespace WindowsFormsApp1.controls.usercontrols
{
    public partial class Categories_screen : BaseUserControl
    {
        DatabaseManager dbm = new DatabaseManager(ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString);
        
       
        public Categories_screen(bool testFilter)
        { 
            InitializeComponent();

            query = "SELECT TOP 20 * FROM Categories\r\nORDER BY 1 ASC;";

            this.Load += new EventHandler(Categories_screen_Load);  // generating buttons 

        }

        private void Categories_screen_Load(object sender, EventArgs e)
        {

            this.Size = this.Parent.Size;

            

            List<Category> categories = dbm.ExecuteQuery<Category>(query, Category.MapToCategory);

            UserControl[] CategoryButtons = Category_button.CreateCategoryButtons(categories, this).ToArray() ;

            AddControlstoFlowPanel(CategoryButtons, categoriesPanel, 3);



        }

        private void categoriesTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tablePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lookinforLabel_Click(object sender, EventArgs e)
        {

        }


       


    }
}
