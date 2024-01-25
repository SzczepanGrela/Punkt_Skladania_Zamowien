using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.interfaces;
using System.IO;
using System.Windows.Forms;
using System.Linq.Expressions;


namespace WindowsFormsApp1.classes.FileOperations
{
    internal class TxtFileOperations : FileOperations
    {


        public string[] ReadFile(string filePath) 
        {

            try
            {

                if (!CheckTheFormat(filePath, "txt")) throw new FormatException("The format is not correct"); // Making sure the file format is .txt

                if (File.Exists(filePath))
                {
                    string[] content = File.ReadAllLines(filePath);

                    return content;
                }
                else
                {
                    throw new FileNotFoundException("File not found: ", filePath);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                string[] content;
                content = new string[1];
                content[0] = ex.Message;
                return content;
            }

        }

        public void WriteFile(string filePath, string content)
        {

            try
            {

                FixTheFormat(filePath, "txt"); // Making sure the file format is .txt


                File.WriteAllText(filePath, content);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        public void UpdateFile(string filePath, string content)
        {
            try
            {


                FixTheFormat(filePath, "txt"); // Making sure the file format is .txt



                File.AppendAllText(filePath, content);



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        public void UpdateFile(string filePath, string[] content)
        {
            
                FixTheFormat(filePath, "txt"); // Making sure the file format is .txt



                File.AppendAllLines(filePath, content);


            


        }


        public void WriteFile(string filePath, string[] content)
        {
            

                FixTheFormat(filePath, "txt"); // Making sure the file format is .txt

                File.WriteAllLines(filePath, content);

           

        }


        public void DeleteFile(string filePath)
        {
              if (!CheckTheFormat(filePath, "txt")) throw new FormatException("The format is not correct"); // Making sure the file format is .txt

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                else throw new FileNotFoundException("File not found: " + filePath);



            
        }


        public void CopyFile(string sourceFilePath, string destinationFilePath)
        {

            
                string[] content = ReadFile(sourceFilePath);

                WriteFile(destinationFilePath, content);

                
         
            


        }

        // moving the file or changing the name of the file
        public void MoveFile(string sourceFilePath, string destinationFilePath)
        {
            

                if (!FileExists(sourceFilePath))
                {
                    throw new Exception("File not found: " + sourceFilePath);
                }

                if (FileExists(destinationFilePath))
                {
                    throw new Exception("File already exists: " + destinationFilePath);
                }


                CopyFile(sourceFilePath, destinationFilePath);
                DeleteFile(sourceFilePath);

            



        }


        public bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }

    }
}
