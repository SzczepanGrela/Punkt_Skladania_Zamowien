using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Classes
{
    public static class Methods
    {
       

        public static void ChangeWindow(Panel panel, Form newForm)
        {
            Main_window.previousWindows.Push(newForm);
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(newForm);
            newForm.Show();
            

        }


        public static void ChangeWindow(Form form, Form newForm) // Function opening new form instead of the current one
        {
            Main_window.previousWindows.Push(newForm);
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            form.Controls.Clear();
            form.Controls.Add(newForm);
            newForm.Show();
        }





        public static void LoadImagesAndCreateButtons(Panel panel, string folderPath)   // Function loading images from folder and creating buttons with them
        {
            string[] files = Directory.GetFiles(folderPath, "*.png");
            int defaultX = 10; 
            int x = defaultX;
            int  y = 0;
            int buttonWidth = 150;
            int buttonHeight = 150;
            int margin = 15;

            foreach (string file in files)
            {
                Button button = new Button();
                button.Image = ResizeImage(new Bitmap(file), buttonWidth, buttonHeight);
                button.Location = new Point(x, y);
                button.Size = new Size(buttonWidth, buttonHeight);
                button.Click += (sender, e) => { MessageBox.Show("Kliknięto: " + file); }; // ADD ACTION TO BUTON 

                panel.Controls.Add(button);

                x += buttonWidth + margin;
                if (x + buttonWidth > panel.Width)
                {
                    x = defaultX;
                    y += buttonHeight + margin;
                }
            }
        }

        private static Image ResizeImage(Image img, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics gfx = Graphics.FromImage(resizedImage))
            {
                gfx.DrawImage(img, new Rectangle(0, 0, width, height));
            }
            return resizedImage;
        }




    }
}
