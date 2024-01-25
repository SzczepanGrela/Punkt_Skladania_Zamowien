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

          void CopyFile();


          void DeleteFile();


          bool FileExists();


          void MoveFile();


          string[] ReadFile();

          void UpdateFile();

          void WriteFile();








    }
}
