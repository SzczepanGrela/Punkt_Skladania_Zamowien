using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.interfaces;

namespace WindowsFormsApp1.classes.FileOperations
{
    internal class sqlFileOperations : IFileOperations
    {
        public void OpenDataStore(string pathOrConnectionString)
        {

        }
        public void CloseDataStore()
        {

        }
        public string ReadData(string query = null)
        {
            return null;
        }
        public void WriteData(string id, string data)
        {
            data = "text";
        }
        public void UpdateData(string id, string data)
        {

        }
        public void DeleteData(string id)
        {

        }
        public string QueryData(string query)
        {
            return null;
        }
    }
}
