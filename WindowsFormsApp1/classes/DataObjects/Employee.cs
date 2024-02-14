using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.classes.DataObjects
{
    internal class Employee
    {
        private int ID { get; set; }
        private string FirstName { get; set; }

        private string LastName { get; set; }

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

    }
}
