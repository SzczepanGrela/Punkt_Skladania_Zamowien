using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.interfaces;
using System.IO;


namespace WindowsFormsApp1.classes.FileOperations
{
    internal class txtFileOperations : IFileOperations
    {
        StreamWriter sw;

        public void OpenDataStore(string pathOrConnectionString)
        {

        }
        public void CloseDataStore()
        {

        }
        public string ReadData(string query = null)
        {
            return "text";
        }
        public void WriteData(string id, string data)   // overwrites existing file
        {
            if (!File.Exists(id)) File.Create(id);

            using (sw = File.CreateText(id))
            {
                sw.WriteLine(data);
            }

        }
        public void UpdateData(string id, string data)   //appends to existing file
        {
            using (sw = File.AppendText(id))
            {
                sw.WriteLine(data);

            }


        }
        public void DeleteData(string id)
        {

            File.Delete(id);
        }
        public string QueryData(string query)
        {
            return "text";
        }
    }
}
