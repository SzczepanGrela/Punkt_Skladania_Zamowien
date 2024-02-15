using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.classes.DataObjects;
using WindowsFormsApp1.classes.FileOperations;
using WindowsFormsApp1.classes.Methods;


namespace WindowsFormsApp1.classes.DataObjects
{
    internal class Customer : Person
    {
        

        
        private string Username { get; set; }

        private string Password { get; set; }

        private string CardID { get; set; }

        private string PersonID { get; set; }


        public Customer()
        {
        }

        public Customer(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public Customer(string FirstName, string LastName, string username, string password, string cardID, string personID, string contactinfo) : base(FirstName, LastName, contactinfo)
        {
            this.Username = username;
            this.Password = password;
            this.CardID = cardID;
            this.PersonID = personID;
        }


        public bool Login()
        {
            DatabaseManager dbm = DatabaseManager.GetInstance();


            string query = "SELECT COUNT(*) FROM Customers WHERE Username = " + StringMethods.addApostrophes(this.Username) + " AND Password = " + StringMethods.addApostrophes(this.Password);
            int count = dbm.CountMatchingRecords(query);


            if (count == 0)
            {
                return false;
            }

            else if (count == 1)
            {
                return true;
            }

            else throw new Exception("Multiple records found for the same username and password");
            
            
        }



        public static Customer MapToCustomer(SqlDataReader reader)
        {
            return new Customer
            {
               ID = reader.GetInt32(reader.GetOrdinal("CustomerID")),
               Name = reader.GetString(reader.GetOrdinal("FirstName")),
               LastName = reader.GetString(reader.GetOrdinal("LastName")),
               
            };
        }
       


    }
}
