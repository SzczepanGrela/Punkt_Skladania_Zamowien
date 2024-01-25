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
    internal class txtFileOperations : FileOperations
    {
        

        new T[] ReadFile<T>(string filePath) where T : class
        {

            try
            {

                if (!CheckTheFormat(filePath, "txt")) throw new FormatException("The format is not correct"); // Making sure the file format is .txt

                if (File.Exists(filePath))
                {
                    string[] content = File.ReadAllLines(filePath);

                    return content as T[];
                }
                else
                {
                    throw new FileNotFoundException("File not found: ", filePath);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        new void WriteFile<T>(string filePath, T content)
        {

            try
            {

                FixTheFormat(filePath, "txt"); // Making sure the file format is .txt



                if (content.GetType() == typeof(string))
                {

                    File.WriteAllText(filePath, content as string);

                }
                
                else throw new FormatException("The content is not a string");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void WriteFile<T>(string filePath, T[] content)
        {
            try
            {

                FixTheFormat(filePath, "txt"); // Making sure the file format is .txt


                if (content.GetType() == typeof(string[]))
                {

                    File.WriteAllLines(filePath, content as string[]);

                }

                else throw new FormatException("The content is not a string array");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        new void UpdateFile<T>(string filePath, T content)
        {
            try
            {


                FixTheFormat(filePath, "txt"); // Making sure the file format is .txt


                if (content.GetType() == typeof(string))
                {

                    File.AppendAllText(filePath, content as string);

                }
                else throw new FormatException("The content is not a string");


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        void UpdateFile<T>(string filePath, T[] content)
        {
            try
            {
                FixTheFormat(filePath, "txt"); // Making sure the file format is .txt


                if (content.GetType() == typeof(string[]))
                {

                    File.AppendAllLines(filePath, content as string[]);

                }
                
                else throw new FormatException("The content is not a string array");


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }





        new void DeleteFile(string filePath)
        {
            try
            {
                if (!CheckTheFormat(filePath, "txt")) throw new FormatException("The format is not correct"); // Making sure the file format is .txt

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                else throw new FileNotFoundException("File not found: "+ filePath);



            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        new void CopyFile(string sourceFilePath, string destinationFilePath)
        {

            try
            {
                string[] content = ReadFile<string>(sourceFilePath);

                WriteFile<string>(destinationFilePath, content);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        // moving the file or changing the name of the file
        new void MoveFile(string sourceFilePath, string destinationFilePath)
        {
            try
            {

                if(!FileExists(sourceFilePath))
                {
                    throw new Exception("File not found: " + sourceFilePath);
                }

                if(FileExists(destinationFilePath))
                {
                    throw new Exception("File already exists: " + destinationFilePath);
                }


                CopyFile(sourceFilePath, destinationFilePath);
                DeleteFile(sourceFilePath);

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           


        }


        new bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }

    }
}
