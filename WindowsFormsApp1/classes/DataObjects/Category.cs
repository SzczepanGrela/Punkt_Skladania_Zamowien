using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.classes.DataObjects
{
    public class Category : Object
    {
        
        
        public byte[] Image { get; private  set; }

        public int Testable { get; private set;}
    
       

        public Category()
        {

        }





        public static Category MapToCategory(SqlDataReader reader)
        {
            return new Category
            {
                ID = reader.GetInt32(reader.GetOrdinal("CategoryID")),
                Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? null : (string)reader["Name"],
                Image = reader.IsDBNull(reader.GetOrdinal("Image")) ? null : (byte[])reader["Image"],
                Testable = reader.IsDBNull(reader.GetOrdinal("Testable")) ? 0 : reader.GetInt32(reader.GetOrdinal("Testable"))


            };
        }

    }
}
