using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.classes.DataObjects;
using WindowsFormsApp1.classes.FileOperations;



namespace WindowsFormsApp1.classes.DataObjects
{
    internal class Customer : Person
    {
        

        DatabaseManager dbm = DatabaseManager.GetInstance();
        private string Username { get; set; }

        private string Password { get; set; }

        private string CardID { get; set; }

        public int CustomerID { get; protected set; }  


        public Customer()
        {
        }

        public Customer(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public Customer(string FirstName, string LastName, string username, string password, string cardID, int personID, string contactinfo) : base(FirstName, LastName, contactinfo, personID)
        {
            this.Username = username;
            this.Password = password;
            this.CardID = cardID;
            this.ID = personID;
        }

        public Customer(Customer customeerToCopy)
        {

            this.CustomerID = customeerToCopy.CustomerID;
            this.Username = customeerToCopy.Username;
            this.Password = customeerToCopy.Password;
            this.CardID = customeerToCopy.CardID;
            this.ID = customeerToCopy.ID;
            this.Name = customeerToCopy.Name;
            this.LastName = customeerToCopy.LastName;
            this.ContactInfo = customeerToCopy.ContactInfo;

        }




        public Customer(int CustomerID)
        {
           
            string query = " SELECT * FROM Customers inner join Persons on Customers.PersonID = Persons.ID WHERE CustomerID = " + CustomerID;

            Customer customeerToCopy = dbm.ExecuteQuery<Customer>(query, MapToCustomer)[0];
            this.CustomerID = customeerToCopy.CustomerID;
            this.Username = customeerToCopy.Username;
            this.Password = customeerToCopy.Password;
            this.CardID = customeerToCopy.CardID;
            this.ID = customeerToCopy.ID;
            this.Name = customeerToCopy.Name;
            this.LastName = customeerToCopy.LastName;
            this.ContactInfo = customeerToCopy.ContactInfo;

        }




        public Customer Login()
        {
            DatabaseManager dbm = DatabaseManager.GetInstance();


            string query = $"SELECT * FROM Customers inner join Persons on Customers.PersonID = Persons.ID WHERE Username = '{Username}' AND Password = '{Password}'";
            //int count = dbm.CountRecords(query);

            List <Customer> records = dbm.ExecuteQuery(query, MapToCustomer);

            
            if(records.Count == 1)
            {
                return records[0];
            }
            else if (records.Count > 1)
            {
                throw new Exception("More than one customer with the same username and password");
            }
            else
            {
                return null;
            }
            
        }



        public static Customer MapToCustomer(SqlDataReader reader)
        {
            return new Customer
            {
               

               CustomerID = reader.IsDBNull(reader.GetOrdinal("CustomerID")) ? 0 : reader.GetInt32(reader.GetOrdinal("CustomerID")),
               CardID = reader.IsDBNull(reader.GetOrdinal("CardID")) ? null : reader.GetString(reader.GetOrdinal("CardID")),
               ID = reader.GetInt32(reader.GetOrdinal("PersonID")),
               Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? null : reader.GetString(reader.GetOrdinal("Name")),
               LastName = reader.IsDBNull(reader.GetOrdinal("LastName")) ? null : reader.GetString(reader.GetOrdinal("LastName")),
               ContactInfo = reader.IsDBNull(reader.GetOrdinal("ContactInfo")) ? null : reader.GetString(reader.GetOrdinal("ContactInfo"))



            };
        }



       


    }
}
