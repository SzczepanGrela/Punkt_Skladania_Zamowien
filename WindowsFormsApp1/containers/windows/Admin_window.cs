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
using WindowsFormsApp1.containers.windows.Admin_screens;

namespace WindowsFormsApp1.containers.windows
{
    public partial class Admin_window : BaseForm
    {
        public Admin_window()
        {
            InitializeComponent();
        }

        private void AddProducts_Click(object sender, EventArgs e)
        {
            this.screenPanel.Controls.Clear();
            AddProducts_screen addProducts = new AddProducts_screen();
            this.screenPanel.Controls.Add(addProducts);
            addProducts.Focus();
            
        }

        private void RemoveProducts_Click(object sender, EventArgs e)
        {
            this.screenPanel.Controls.Clear();
            this.screenPanel.Controls.Add(new RemoveProducts_screen());
        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            this.screenPanel.Controls.Clear();
            this.screenPanel.Controls.Add(new AddCategory_screen());
        }

        private void removeCategory_Click(object sender, EventArgs e)
        {
            this.screenPanel.Controls.Clear();
            this.screenPanel.Controls.Add(new RemoveCategory_screen());

        }

        private void AddEmployees_Click(object sender, EventArgs e)
        {
            this.screenPanel.Controls.Clear();
            this.screenPanel.Controls.Add(new AddEmployee_screen());

        }

        private void RemoveEmployees_Click(object sender, EventArgs e)
        {
            this.screenPanel.Controls.Clear();
            this.screenPanel.Controls.Add(new RemoveEmployee_screen());

        }
    }
}
