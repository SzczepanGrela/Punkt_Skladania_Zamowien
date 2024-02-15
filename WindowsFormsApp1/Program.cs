using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes.FileOperations;

namespace WindowsFormsApp1
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            DatabaseManager dbManager = DatabaseManager.GetInstance(ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Resolution.setResolution(1200, 900, 682, 766);

            Main_window mw = new Main_window();  // create an instance of the main window
            Application.Run(mw);

        }
    }
}
