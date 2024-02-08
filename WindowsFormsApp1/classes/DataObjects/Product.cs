using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.classes.DataObjects
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Decimal Price { get; set; }

        public string Description { get; set; }

        public int CategoryID { get; set; }

        public int StockQuantity { get; set; }

        public byte[] Image { get; set; }


        public Product()
        {

        }

       


        public static Product MaptoButton(SqlDataReader reader)
        {
            return new Product
            {
                ID = reader.GetInt32(reader.GetOrdinal("ProductID")),
                Name = reader.GetString(reader.GetOrdinal("Name")),
                Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                
                CategoryID = reader.GetInt32(reader.GetOrdinal("CategoryID")),
                
                Image = reader.IsDBNull(reader.GetOrdinal("Image")) ? null : (byte[])reader["Image"]

            };
        }


        public static Product MaptoDetail(SqlDataReader reader)
        {
            return new Product
            {
                ID = reader.GetInt32(reader.GetOrdinal("ProductID")),
                Name = reader.GetString(reader.GetOrdinal("Name")),
                Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                Description = reader.GetString(reader.GetOrdinal("Description")),
                CategoryID = reader.GetInt32(reader.GetOrdinal("CategoryID")),
                StockQuantity = reader.GetInt32(reader.GetOrdinal("StockQuantity")),
                Image = reader.IsDBNull(reader.GetOrdinal("Image")) ? null : (byte[])reader["Image"]

            };
        }



    }
}
