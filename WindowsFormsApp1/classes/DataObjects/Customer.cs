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

        public string Username { get; set; }

        public string Password { get; set; }

        public string CardID { get; set; }

        public string PersonID { get; set; }


        public Customer(string username, string password) : base()
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
            DatabaseManager dbm = new DatabaseManager(ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString);
           

            string query = "SELECT COUNT(*) FROM Customers WHERE Username = " + Methods.addApostrophes(this.Username) + " AND Password = " + Methods.addApostrophes(this.Password);
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





    }
}
