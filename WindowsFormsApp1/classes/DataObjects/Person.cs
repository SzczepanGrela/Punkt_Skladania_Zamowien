using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.classes.FileOperations;



namespace WindowsFormsApp1.classes.DataObjects
{
    internal abstract class Person:Object
    {

     
        protected string LastName { get; set; } 

        protected string ContactInfo { get; set; } 

        

        public Person(string FirstName, string LastName, string ContactInfo, int PersonID)
        {
            this.Name = FirstName;
            this.ID = PersonID;
            this.LastName = LastName;
            this.ContactInfo = ContactInfo;
        }

        public Person(string FirstName, string LastName, string ContactInfo)
        {
            this.Name = FirstName;
           
            this.LastName = LastName;
            this.ContactInfo = ContactInfo;
        }

        public Person()
        {

        }


        public static SqlParameter[] MapPersonToSqlParameters(Person person)
        {
            return new SqlParameter[]
            {
                      new SqlParameter("@Name", person.Name),
                      new SqlParameter("@LastName", person.LastName),
                      new SqlParameter("@ContactInfo", person.ContactInfo)
            };
        }


    }
}
