using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.classes.FileOperations;



namespace WindowsFormsApp1.classes.DataObjects
{
    internal abstract class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; } 

        public string ContactInfo { get; set; } = string.Empty;

        

        public Person(string FirstName, string LastName, string ContactInfo)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.ContactInfo = ContactInfo;
        }

        public Person()
        {

        }

        
    }
}
