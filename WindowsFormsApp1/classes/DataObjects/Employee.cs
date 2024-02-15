using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1.classes.DataObjects
{
    internal class Employee : Person
    {
        private string password;

        private string Position { get; set; }

        private int EmployeeID { get; set; }
        private string CardID { get; set; }

        public Employee(string FirstName, string LastName, string ContactInfo) : base(FirstName, LastName, ContactInfo)
        {
           
      
        }


        public Employee( string FirstName, string LastName, string ContactInfo, string cardID, string password, string position, int PersonID) : base(FirstName, LastName, ContactInfo, PersonID)
        {

            CardID = cardID;
            this.password = password;
            Position = position;
        }



        public Employee()
        {
        }




        public static Employee MaptoEmployeeLogin(SqlDataReader reader)
        {
            return new Employee
            {
                ID = reader.IsDBNull(reader.GetOrdinal("ID")) ? 0 : reader.GetInt32(reader.GetOrdinal("ID")),
                CardID = reader.IsDBNull(reader.GetOrdinal("CardID")) ? null : reader.GetString(reader.GetOrdinal("CardID")), 
            };
        }

        public static Employee MaptoEmployee(SqlDataReader reader)
        {
            return new Employee
            {
                EmployeeID = reader.IsDBNull(reader.GetOrdinal("EmployeeID")) ? 0 : reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? null : reader.GetString(reader.GetOrdinal("Name")),
                LastName = reader.IsDBNull(reader.GetOrdinal("LastName")) ? null : reader.GetString(reader.GetOrdinal("LastName")),
                Position = reader.IsDBNull(reader.GetOrdinal("Position")) ? null : reader.GetString(reader.GetOrdinal("Position")),
                ContactInfo = reader.IsDBNull(reader.GetOrdinal("ContactInfo")) ? null : reader.GetString(reader.GetOrdinal("ContactInfo")),
                CardID = reader.IsDBNull(reader.GetOrdinal("CardID")) ? null : reader.GetString(reader.GetOrdinal("CardID")),
            };
        }


        public static SqlParameter[] MapEmployeeToSqlParameters(Employee employee)
        {
            return new SqlParameter[]
            {
                      new SqlParameter("@CardID", employee.ID ),
                      new SqlParameter("@Position", employee.Position),
                      new SqlParameter("@Password", employee.password),
                      new SqlParameter("@PersonID", employee.ID)
            };
        }




    }
}
