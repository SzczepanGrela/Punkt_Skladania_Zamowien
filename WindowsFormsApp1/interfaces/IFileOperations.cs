using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WindowsFormsApp1.interfaces
{
    internal interface IFileOperations
    {

        T ReadFile<T>(string filePath);

        void WriteFile<T>(string filePath, T content);

        void UpdateFile<T>(string filePath, T content);


        void DeleteFile(string filePath);


        void CopyFile(string sourceFilePath, string destinationFilePath);

        // moving the file or changing the name of the file
        void MoveFile(string sourceFilePath, string destinationFilePath);


        bool FileExists(string filePath);








    }
}
