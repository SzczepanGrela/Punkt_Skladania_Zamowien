using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.interfaces;

namespace WindowsFormsApp1.classes.FileOperations
{
    internal class FileOperations : IFileOperations
    {
        private FileStream fs;
        private StreamReader sr;
        private StreamWriter sw;


        public void CopyFile(string sourceFilePath, string destinationFilePath)
        {
            throw new NotImplementedException();
        }

        public void DeleteFile(string filePath)
        {
            throw new NotImplementedException();
        }

        public bool FileExists(string filePath)
        {
            throw new NotImplementedException();
        }

        public void MoveFile(string sourceFilePath, string destinationFilePath)
        {
            throw new NotImplementedException();
        }

        public T ReadFile<T>(string filePath)
        {
            throw new NotImplementedException();
        }

        public void UpdateFile<T>(string filePath, T content)
        {
            throw new NotImplementedException();
        }

        public void WriteFile<T>(string filePath, T content)
        {
            throw new NotImplementedException();
        }



        protected void FixTheFormat(string filePath, string correctFormat)
        {
            try
            {
                int i;
                for (i = filePath.Length - 1; i > 0; i++)
                {
                    if (filePath[i] == '.')
                    {
                        if (filePath.Substring(i + 1) == correctFormat)
                        {
                            break;
                        }
                        else
                        {
                            filePath = filePath.Substring(0, i + 1) + correctFormat;

                        }
                    }
                }
                if (i == 0)
                {
                    throw new FormatException("Path is not correct: " + filePath);
                }


            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        protected bool CheckTheFormat(string filePath, string correctFormat)
        {
            try
            {
                int i;
                for (i = filePath.Length - 1; i > 0; i++)
                {
                    if (filePath[i] == '.')
                    {
                        if (filePath.Substring(i + 1) == correctFormat)
                        {
                            return true;
                        }
                        else
                        {
                            throw new FormatException("File format is not supported: " + filePath.Substring(i + 1));

                        }
                    }
                }


                throw new FormatException("Path is not correct: " + filePath);  // If there is no dot in the path

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }





    }
}


