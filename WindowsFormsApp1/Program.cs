using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {



        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Resolution.setResolution(1200, 900, 682, 766);
           
            Main_window mw = new Main_window();  // create an instance of the main window
            Application.Run(mw);

        }
    }
}
