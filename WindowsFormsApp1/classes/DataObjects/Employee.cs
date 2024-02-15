using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.classes.DataObjects
{
    internal class Employee : Person
    {
        
       
        private string Position { get; set; } 

        private string contactInfo { get; set; }

        private string CardID { get; set; }





        public static Employee MaptoEmployeeLogin(SqlDataReader reader)
        {
            return new Employee
            {
                ID = reader.IsDBNull(reader.GetOrdinal("EmployeeID")) ? 0 : reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                CardID = reader.IsDBNull(reader.GetOrdinal("CardID")) ? null : reader.GetString(reader.GetOrdinal("CardID")), 
            };
        }

        public static Employee MaptoEmployee(SqlDataReader reader)
        {
            return new Employee
            {
                ID = reader.IsDBNull(reader.GetOrdinal("EmployeeID")) ? 0 : reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                FirstName = reader.IsDBNull(reader.GetOrdinal("FirstName")) ? null : reader.GetString(reader.GetOrdinal("FirstName")),
                LastName = reader.IsDBNull(reader.GetOrdinal("LastName")) ? null : reader.GetString(reader.GetOrdinal("LastName")),
                Position = reader.IsDBNull(reader.GetOrdinal("Position")) ? null : reader.GetString(reader.GetOrdinal("Position")),
                contactInfo = reader.IsDBNull(reader.GetOrdinal("ContactInfo")) ? null : reader.GetString(reader.GetOrdinal("ContactInfo")),
                CardID = reader.IsDBNull(reader.GetOrdinal("CardID")) ? null : reader.GetString(reader.GetOrdinal("CardID")),
            };
        }

    }
}
