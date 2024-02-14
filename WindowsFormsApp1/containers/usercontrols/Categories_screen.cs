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
using WindowsFormsApp1.containers.usercontrols;
using WindowsFormsApp1.containers.usercontrols.controls;

namespace WindowsFormsApp1.controls.usercontrols
{
    public partial class Categories_screen : BaseUserControl
    {

        DatabaseManager dbm = DatabaseManager.GetInstance();

        private bool Testable;

        public Categories_screen(bool Testable)
        { 
            InitializeComponent();


            

            this.Load += new EventHandler(Categories_screen_Load);  // generating buttons 
            this.Testable = Testable;

        }

        private void Categories_screen_Load(object sender, EventArgs e)
        {



            query = "SELECT TOP 20 * FROM Categories";
            if (Testable)
            {
                query += " where Testable = 1";
            }


            List<Category> categories = dbm.ExecuteQuery<Category>(query, Category.MapToCategory);

            UserControl[] CategoryButtons = Category_button.CreateCategoryButtons(categories, Testable).ToArray() ;

            AddButtonstoFlowPanel(CategoryButtons, categoriesPanel, 3);



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
