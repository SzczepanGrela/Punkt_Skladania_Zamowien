using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.classes.DataObjects
{
    
    public class Cart : Object
    {
        protected Dictionary<Product, int> items = new Dictionary<Product, int>();

        

        private DateTime createdDate { get; set; }

        private string Status { get; set; }

        private int CustomerID { get; set; }

      
        public static Cart MapToCart(SqlDataReader reader)
        {
            return new Cart
            {
                ID = reader.GetInt32(reader.GetOrdinal("CartID")),
                CustomerID = reader.GetInt32(reader.GetOrdinal("CustomerID")),
                createdDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate")),
                Status = reader.GetString(reader.GetOrdinal("Status"))

            };
        }





    }
}
