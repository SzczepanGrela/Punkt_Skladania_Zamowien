using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.interfaces
{
    internal interface IFileOperations
    {

        void OpenDataStore(string pathOrConnectionString);
        void CloseDataStore();
        string ReadData(string query = null);
        void WriteData(string id, string data);
        void UpdateData(string id, string data);
        void DeleteData(string id);
        string QueryData(string query);
    }
}
