using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.classes.DataObjects
{
    public class Product : Object
    {
        // Fields accessiible from outside, modifable only from the insdee


        public Decimal Price { get; protected set; }

        public string Description { get; protected set; }

        public int CategoryID { get; protected set; }

        public int StockQuantity { get; protected set; }

        public byte[] Image { get; protected set; }





        public Product()
        {
        }

        public Product(string name, Decimal price, string description, int categoryID, int stockQuantity)
        {
            Name = name;
            Price = price;
            Description = description;
            CategoryID = categoryID;
            StockQuantity = stockQuantity;

        }




        public Product(int id, string name, Decimal price, string description, int categoryID, int stockQuantity, byte[] image)
        {
            ID = id;
            Name = name;
            Price = price;
            Description = description;
            CategoryID = categoryID;
            StockQuantity = stockQuantity;
            Image = image;
        }





















        public static Product MaptoButton(SqlDataReader reader)    // Map to Boject fitting creteria for button
        {
            return new Product
            {
                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? null : reader.GetString(reader.GetOrdinal("Name")),
                Price = reader.IsDBNull(reader.GetOrdinal("Price")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Price")),

                CategoryID = reader.GetInt32(reader.GetOrdinal("CategoryID")),

                Image = reader.IsDBNull(reader.GetOrdinal("Image")) ? null : (byte[])reader["Image"]

            };
        }



        public static Product MaptoProductSlice(SqlDataReader reader)    // same but woth slices
        {
            return new Product
            {
                ID = reader.GetInt32(reader.GetOrdinal("ID")),
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
                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? null : reader.GetString(reader.GetOrdinal("Name")),
                Price = reader.IsDBNull(reader.GetOrdinal("Price")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Price")),
                Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString(reader.GetOrdinal("Description")),
                CategoryID = reader.GetInt32(reader.GetOrdinal("CategoryID")),
                StockQuantity = reader.GetInt32(reader.GetOrdinal("StockQuantity")),
                Image = reader.IsDBNull(reader.GetOrdinal("Image")) ? null : (byte[])reader["Image"]

            };
        }



        public static SqlParameter[] MapProductToSqlParameters(Product product)
        {
            return new SqlParameter[]
            {
                      new SqlParameter("@Name", product.Name),
                      new SqlParameter("@Price", product.Price),
                      new SqlParameter("@Description", product.Description),
                      new SqlParameter("@CategoryID", product.CategoryID),
                      new SqlParameter("@StockQuantity", product.StockQuantity),
            };
        }

    }
}
