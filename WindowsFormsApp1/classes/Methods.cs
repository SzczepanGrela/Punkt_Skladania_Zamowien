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


        /* public static void ChangeWindow(Form form, Panel panel, Form newForm)
         {


            Form currentForm = panel.Controls.OfType<Form>().FirstOrDefault(); // Pobierz obecny formularz
             if (currentForm != null)
             {
                 currentForm.Hide(); // Ukryj obecny formularz
                 Main_window.previousWindows.Push(currentForm); // Dodaj obecny formularz do stosu
             }

             newForm.TopLevel = false;
             newForm.FormBorderStyle = FormBorderStyle.None;
             newForm.Dock = DockStyle.Fill;
             panel.Controls.Clear();
             panel.Controls.Add(newForm); // Dodaj nowy formularz
             newForm.Show();


         }*/


       

       

         public static void ChangeWindow(Form oldForm, Form newForm) // MAIN WAY OF ADDING NEW FORM TO PANEL
        {


            
           
            Main_window.previousWindows.Push(oldForm);  // add current form to stack
            oldForm.Hide();
            // take current form and add it to stack
            Main_window.MainPanel.Controls.Clear();
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            newForm.FormBorderStyle = FormBorderStyle.None;
            Main_window.MainPanel.Controls.Add(newForm);
            
            newForm.Show(); // show new form
            
        }




        public static void HomeButton()   // home button 
        {
            Main_window.previousWindows.Clear(); // Wyczyść stos
            Menu_window newForm = new Menu_window(); 
            Panel panel = Main_window.MainPanel;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            
            ClearPanel(panel);

            panel.Controls.Add(newForm); // add new form
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


        private static  void ClearPanel(Panel panel)
        {

            foreach (Control control in panel.Controls)
            {
                if (control is Form)
                {
                    ((Form)control).Close();
                }
                control.Dispose();
            }
            
            panel.Controls.Clear();
  
       }




    }
}
