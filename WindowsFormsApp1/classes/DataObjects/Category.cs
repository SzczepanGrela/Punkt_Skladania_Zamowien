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


        public byte[] Image { get; private set; }

        public bool Testable { get; private set; }



        public Category()
        {

        }

        public Category(string name, bool testable)
        {
            Name = name;

            Testable = testable;
        }





        public static Category MapToCategory(SqlDataReader reader)
        {
            return new Category
            {
                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? null : (string)reader["Name"],
                Image = reader.IsDBNull(reader.GetOrdinal("Image")) ? null : (byte[])reader["Image"],
                Testable = reader.IsDBNull(reader.GetOrdinal("Testable")) ? false : true


            };
        }



        public static SqlParameter[] MapCategoryToSqlParameters(Category category)
        {
            return new SqlParameter[]
            {
                      new SqlParameter("@Name", category.Name),

                      new SqlParameter("@Testable", category.Testable)



             };
            



        }


    }
}
