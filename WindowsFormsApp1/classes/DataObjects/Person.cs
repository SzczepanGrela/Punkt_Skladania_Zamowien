using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.classes.FileOperations;



namespace WindowsFormsApp1.classes.DataObjects
{
    internal abstract class Person:Object
    {

        protected string FirstName { get; set; }
        protected string LastName { get; set; } 

        protected string ContactInfo { get; set; } 

        

        public Person(string FirstName, string LastName, string ContactInfo)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.ContactInfo = ContactInfo;
        }

        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public Person()
        {

        }

        
    }
}
