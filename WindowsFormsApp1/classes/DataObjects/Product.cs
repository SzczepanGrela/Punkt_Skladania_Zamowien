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
        public int ID { get; private set; }     // Fields accessiible from outside, modifable only from the insdee
        public string Name { get; private set; }

        public Decimal Price { get; private set; }

        public string Description { get; private set; }

        public int CategoryID { get;  private set; }

        public int StockQuantity { get; private set; }

        public byte[] Image { get;  private set; }


        public Product()
        {

        }

       


        public static Product MaptoButton(SqlDataReader reader)    // Map to Boject fitting creteria for button
        {
            return new Product
            {
                ID = reader.GetInt32(reader.GetOrdinal("ProductID")),
                Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? null : reader.GetString(reader.GetOrdinal("Name")),
                Price = reader.IsDBNull(reader.GetOrdinal("Price")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Price")),

                CategoryID = reader.GetInt32(reader.GetOrdinal("CategoryID")),
                
                Image = reader.IsDBNull(reader.GetOrdinal("Image")) ? null : (byte[])reader["Image"]

            };
        }



        public static Product MaptoSlice(SqlDataReader reader)    // same but woth slices
        {
            return new Product
            {
                ID = reader.GetInt32(reader.GetOrdinal("ProductID")),
                Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? null : reader.GetString(reader.GetOrdinal("Name")),
                Price = reader.IsDBNull(reader.GetOrdinal("Price")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Price")),

                CategoryID = reader.GetInt32(reader.GetOrdinal("CategoryID")),
                StockQuantity = reader.GetInt32(reader.GetOrdinal("StockQuantity")),
                Image = reader.IsDBNull(reader.GetOrdinal("Image")) ? null : (byte[])reader["Image"]

            };
        }







        public static Product MaptoDetail(SqlDataReader reader)
        {
            return new Product
            {
                ID = reader.GetInt32(reader.GetOrdinal("ProductID")),
                Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? null : reader.GetString(reader.GetOrdinal("Name")),
                Price = reader.IsDBNull(reader.GetOrdinal("Price")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Price")),
                Description = reader.IsDBNull(reader.GetOrdinal("Description"))? null : reader.GetString(reader.GetOrdinal("Description")),
                CategoryID = reader.GetInt32(reader.GetOrdinal("CategoryID")),
                StockQuantity = reader.GetInt32(reader.GetOrdinal("StockQuantity")),
                Image = reader.IsDBNull(reader.GetOrdinal("Image")) ? null : (byte[])reader["Image"]

            };
        }



    }
}
