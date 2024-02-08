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

namespace WindowsFormsApp1.controls.usercontrols
{
    public partial class Categories_screen : BaseUserControl
    {
        DatabaseManager dbm = new DatabaseManager(ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString);

       
        public Categories_screen(Control parentContainer, char mode) : base(parentContainer, mode)
        {
            InitializeComponent();

            this.Load += new EventHandler(Categories_screen_Load);  //loading buttons from file

        }

        private void Categories_screen_Load(object sender, EventArgs e)
        {
            string query;
            query = "SELECT TOP 4 * FROM Categories\r\nORDER BY 1 ASC;";
            /* if (mode == 't')
             {
                 query = "SELECT * FROM Categories where Name like 'a%'";
             }*/


            //Category[] categories = dbm.ExecuteQuery<Category>(query, MapToCategory).ToArray();

            List<Category> categories = dbm.ExecuteQuery<Category>(query, Category.MapToCategory).ToList();

            BaseUserControl[] CategoryButtons = Methods.CreateCategoryButtons(categories, this.parentContainer, mode, this).ToArray() ;

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
