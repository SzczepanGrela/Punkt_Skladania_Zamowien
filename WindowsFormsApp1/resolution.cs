using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{


    public static class Resolution
    {


        public static int windowWidth = 528; // default values is: 700   // 528
        public static int windowHeight= 732; // default values is: 900  // 732
        public static int formWidth = 682;  // default value is: 682  // 513
        public static int formHeight = 623; // default value is: 766 // 623

        public static void setResolution(int winWidth, int winHeight, int frmWidth, int frmHeight)
        {

            windowWidth = winWidth;
            windowHeight = winHeight;
            formWidth = frmWidth;
            formHeight = frmHeight;
        }

        public static (int formWidth, int formHeight) GetFormRes()
        {
            return (formWidth, formHeight);
        }


        public static (int windowWidth, int windowHeight) GetWindowRes()
        {
            return (windowWidth, windowHeight);
        }

    }
}
