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



namespace WindowsFormsApp1.classes.DataObjects
{
    internal class Customer : Person
    {
        

        
        private string Username { get; set; }

        private string Password { get; set; }

        private string CardID { get; set; }

        private int CustomerID { get; set; }  


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

        public Customer(int CustomerID)
        {

        }




        public int Login()
        {
            DatabaseManager dbm = DatabaseManager.GetInstance();


            string query = $"SELECT CustomerID FROM Customers inner join Persons on Customers.PersonID = Persons.ID WHERE Username = '{Username}' AND Password = '{Password}'";
            //int count = dbm.CountRecords(query);

            List <Customer> records = dbm.ExecuteQuery(query, MapToCustomer);

            
            if(records.Count == 1)
            {
                return records[0].CustomerID;
            }
            else if (records.Count > 1)
            {
                throw new Exception("More than one customer with the same username and password");
            }
            else
            {
                return -1 ;
            }
            
            
            
            

            
            
            
        }



        public static Customer MapToCustomer(SqlDataReader reader)
        {
            return new Customer
            {
               CustomerID = reader.GetInt32(reader.GetOrdinal("CustomerID")),
               Name = reader.GetString(reader.GetOrdinal("FirstName")),
               LastName = reader.GetString(reader.GetOrdinal("LastName")),
               
            };
        }
       


    }
}
